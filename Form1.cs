using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace IcuInfrared
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath);
        string dataPath = Application.StartupPath + "\\";
        SoundPlayer sp;
        SoundPlayer spNull;
        BedData[] bedDatas = new BedData[BedData.totalNum];

        bool isMute = false;
        bool isOpen = false;
        DateTime openTime = DateTime.Now;

        string bluetoothName = "HUAWEI CM510";
        Thread thread;



        //页面加载，读入数据
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] processList = System.Diagnostics.Process.GetProcessesByName(process.ProcessName);
            if (processList.Length != 1)
            {
                MessageBox.Show("程序已在运行！");
                Environment.Exit(0);
            }

            thread = new Thread(CheckOutDevice);
            thread.IsBackground = true;
            thread.Start();

            sp = new SoundPlayer(@dataPath + "7828.wav");
            sp.Load();
            spNull = new SoundPlayer(@dataPath + "0001.wav");
            spNull.Load();
            string hospitalNumber;
            int disease;
            DateTime nextTime;
            DateTime finishTime;
            for (int i = 0; i < BedData.totalNum; i++)
            {
                StreamReader sr = new StreamReader(dataPath + BedData.fileNames[i] + ".txt", System.Text.Encoding.Default);
                hospitalNumber = sr.ReadLine();
                if (hospitalNumber == null)
                {
                    bedDatas[i] = new BedData();
                    sr.Close();
                    continue;
                }
                disease = Convert.ToInt32(sr.ReadLine());
                nextTime = DateTime.FromFileTime(Convert.ToInt64(sr.ReadLine()));
                finishTime = DateTime.FromFileTime(Convert.ToInt64(sr.ReadLine()));
                bedDatas[i] = new BedData(hospitalNumber, disease, nextTime, finishTime, dataPath, BedData.fileNames[i]);
                sr.Close();
            }
            comboBoxDisease.SelectedIndex = 0;
            listBoxBedNumber.SelectedIndex = 0;

            CheckInfrared();
            CheckBed();
            CheckFile();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        //每30秒检查提示
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            spNull.Play();
            CheckInfrared();
            CheckBed();
            timer1.Enabled = true;
        }
        //检查热像仪提示
        private void CheckInfrared()
        {
            for (int i = 0; i < BedData.totalNum; i++)
            {
                if (bedDatas[i].Get_isEmpty())
                {
                    continue;
                }
                if (!bedDatas[i].Get_isBlanket() && bedDatas[i].Get_nextTime().ToFileTime() < DateTime.Now.ToFileTime() + 9000000000)
                {
                    OpenInfrared();//开启设备
                    return;
                }
            }

            CloseInfrared();//关闭设备
        }
        private void OpenInfrared()
        {
            if (isOpen)
            {
                labelInfraredDo.Text = "若未开启请及时开启\n开机15分钟后方可使用";
                labelInfraredDo.ForeColor = Color.Black;
                buttonInfrared.ForeColor = Color.Black;
            }
            else
            {
                Play7828();
                labelInfraredDo.Text = "请开启热像仪,开启后点击确定";
                labelInfraredDo.ForeColor = Color.Red;
                buttonInfrared.ForeColor = Color.Red;
                buttonInfrared.Visible = true;
            }
        }
        private void CloseInfrared()
        {
            for (int i = 0; i < BedData.totalNum; i++)
            {
                if (bedDatas[i].Get_isEmpty())
                {
                    continue;
                }
                if ((bedDatas[i].Get_nextTime().ToFileTime() - DateTime.Now.ToFileTime()) / 10000000 < 10800)
                {
                    if (isOpen)
                    {
                        labelInfraredDo.Text = "若未开启请及时开启";
                        labelInfraredDo.ForeColor = Color.Black;
                        buttonInfrared.ForeColor = Color.Black;
                    }
                    else
                    {
                        labelInfraredDo.Text = "若已开启请点击确定按钮刷新状态";
                        labelInfraredDo.ForeColor = Color.Black;
                        buttonInfrared.ForeColor = Color.Black;
                        buttonInfrared.Visible = true;
                    }
                    return;
                }
            }

            if (isOpen)
            {
                Play7828();
                labelInfraredDo.Text = "请关闭热像仪";
                labelInfraredDo.ForeColor = Color.Red;
                buttonInfrared.ForeColor = Color.Red;
                buttonInfrared.Visible = true;
            }
            else
            {
                labelInfraredDo.Text = "若未关闭请及时关闭";
                labelInfraredDo.ForeColor = Color.Black;
                buttonInfrared.ForeColor = Color.Black;
            }
        }
        //检查床位、电脑提示
        private void CheckBed()
        {
            bool isAllEmpty = true;
            for (int i = 0; i < BedData.totalNum; i++)
            {
                if (bedDatas[i].Get_isEmpty())
                {
                    continue;
                }
                isAllEmpty = false;
                if (!bedDatas[i].Get_isBlanket() && !isOpen && bedDatas[i].Get_nextTime().ToFileTime() < DateTime.Now.AddMinutes(10).ToFileTime())
                {
                    bedDatas[i].Delay(10);
                    continue;
                }
                if (bedDatas[i].Get_nextTime().ToFileTime() < DateTime.Now.ToFileTime())
                {
                    labelComputerDo.Text = "";
                    RefreshAll();
                    Play7828();
                    return;
                }
            }
            if (isAllEmpty)
            {
                Play7828();
                labelComputerDo.Text = "若无新病人入组，请关机";
            }
            else if (SystemInformation.PowerStatus.PowerLineStatus.ToString().Equals("Offline"))
            {
                Play7828();
                labelComputerDo.Text = "请为电脑充电";
            }
            else
            {
                labelComputerDo.Text = "";
            }
        }

        //每1秒检查当前文件
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            CheckFile();
            timer2.Enabled = true;
        }
        private void CheckFile()
        {
            if (isOpen)
            {
                TimeSpan ts1 = new TimeSpan(openTime.Ticks);
                TimeSpan ts2 = new TimeSpan(DateTime.Now.Ticks);
                TimeSpan ts3 = ts2.Subtract(ts1);
                int sec = (int)ts3.TotalSeconds;
                labelInfraredTime.Text = "已开启\n" + sec / 3600 + "时" + sec % 3600 / 60 + "分" + sec % 60 + "秒";
            }
            else
            {
                labelInfraredTime.Text = "已关闭";
            }
            if (bedDatas[listBoxBedNumber.SelectedIndex].Get_isEmpty())
            {
                return;
            }

            long x = bedDatas[listBoxBedNumber.SelectedIndex].Get_nextTime().AddMinutes(-15).ToFileTime();
            if (DateTime.Now.ToFileTime() < x)
            {
                return;
            }

            int num = 0;
            foreach (FileInfo f in directoryInfo.GetFiles(bedDatas[listBoxBedNumber.SelectedIndex].Get_hospitalNumber() + "_*", SearchOption.TopDirectoryOnly))
            {
                DateTime dt;
                string inputstring = f.Name.Split('_')[1];
                try
                {
                    DateTime.TryParseExact(inputstring, "yyyy-MM-dd-HH-mm-ss", null, System.Globalization.DateTimeStyles.None, out dt);
                    long y = dt.ToFileTime();
                    if (y > x)
                    {
                        num++;
                    }
                }
                catch
                {
                    continue;
                }
            }
            if (num > 2)
            {
                Finish();
            }
        }

        //完成
        private void Finish()
        {
            bedDatas[listBoxBedNumber.SelectedIndex].Next(BedData.fileNames[listBoxBedNumber.SelectedIndex]);

            if (DateTime.Now.ToFileTime() > bedDatas[listBoxBedNumber.SelectedIndex].Get_finishTime().ToFileTime())
            {
                StreamWriter sw = new StreamWriter(dataPath + listBoxBedNumber.Text + ".txt", false, System.Text.Encoding.Default);
                sw.Close();
                bedDatas[listBoxBedNumber.SelectedIndex] = new BedData();
                RefreshAll();
                MessageBox.Show("该病人测量完成，感谢您的参与。");
            }
            else
            {
                RefreshAll();
            }
        }
        //播放
        private void Play7828()
        {
            if (!isMute)
            {
                sp.Play();
            }
        }
        private void CheckOutDevice()
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                Thread.Sleep(30000);
                CheckOutDevice1();
            }
        }
        private void CheckOutDevice1()
        {
            if (!checkBoxBluetooth.Checked)
            {
                labelBluetoothDo.Text = "";
                return;
            }
            bool isConnect = false;
            var enumberator = new MMDeviceEnumerator();
            var deviceCollection = enumberator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.All);
            for (int waveOutDevice = 0; waveOutDevice < WaveOut.DeviceCount; waveOutDevice++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(waveOutDevice);
                foreach (MMDevice device in deviceCollection)
                {
                    try
                    {
                        if (device.FriendlyName.StartsWith(deviceInfo.ProductName))
                        {
                            if (device.FriendlyName.Contains(bluetoothName))
                            {
                                isConnect = true;
                                break;
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            if (isConnect)
            {
                labelBluetoothDo.Text = "";
            }
            else
            {
                labelBluetoothDo.Text = "已断开，请连接";
                Play7828();
            }
        }


        //新入组病人
        private void buttonNew_Click(object sender, EventArgs e)
        {
            string hospitalNumber;
            int disease;
            DateTime nextTime;
            DateTime finishTime;

            DateTime dateTime = DateTime.Now;
            if (textBoxNewHospitalNumber.Text.Length < 6)
            {
                textBoxNewHospitalNumber.Text = "";
                MessageBox.Show("请输入住院号");
                return;
            }
            hospitalNumber = textBoxNewHospitalNumber.Text;
            disease = comboBoxDisease.SelectedIndex;
            nextTime = dateTime;
            finishTime = dateTime.AddHours(BedData.timetotal[disease] + BedData.timeInterval[disease]);
            textBoxNewHospitalNumber.Text = "";

            bedDatas[listBoxBedNumber.SelectedIndex] = new BedData(hospitalNumber, disease, nextTime, finishTime, dataPath, BedData.fileNames[listBoxBedNumber.SelectedIndex]);

            StreamWriter sw = new StreamWriter(dataPath + listBoxBedNumber.Text + ".txt", false, System.Text.Encoding.Default);
            sw.WriteLine(hospitalNumber);//住院号
            sw.WriteLine(disease.ToString());//疾病种类
            sw.WriteLine(nextTime.ToFileTime().ToString());//上一次记录时间
            sw.WriteLine(finishTime.ToFileTime().ToString());//入组时间
            sw.Close();

            RefreshAll();
            CheckInfrared();
            CheckBed();
        }

        //复制文件名
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if(textBoxRespond.Text == "")
            {
                MessageBox.Show("请输入工号");
                return;
            }
            if(bedDatas[listBoxBedNumber.SelectedIndex].Get_nextTime().ToFileTime() > DateTime.Now.ToFileTime() || bedDatas[listBoxBedNumber.SelectedIndex].Get_isBlanket())
            {
                panelNow.Enabled = false;
                listBoxBedNumber.Enabled = false;
                panelAdd.Visible = true;
                return;
            }
            string s = bedDatas[listBoxBedNumber.SelectedIndex].Get_hospitalNumber() + "_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "_" + textBoxRespond.Text + "_";
            Clipboard.SetDataObject(s);
            buttonCopy.Text = "复制成功";
            buttonCopy.Enabled = false;
            timer4.Enabled = true;
        }
        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            if (textBoxAdd.Text.Trim() == "")
            {
                textBoxAdd.Text = "";
                MessageBox.Show("请输入加拍原因");
            }
            else if (textBoxAdd.Text.Length > 20)
            {
                textBoxAdd.Text = "";
                MessageBox.Show("输入长度不能超过20");
            }
            else
            {
                string s = bedDatas[listBoxBedNumber.SelectedIndex].Get_hospitalNumber() + "_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "_" + textBoxRespond.Text + "_";
                s = s + textBoxAdd.Text.Trim();
                Clipboard.SetDataObject(s);
                textBoxAdd.Text = "";
                panelAdd.Visible = false;
                panelNow.Enabled = true;
                listBoxBedNumber.Enabled = true;
                buttonCopy.Text = "复制成功";
                buttonCopy.Enabled = false;
                timer4.Enabled = true;
            }
        }
        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            textBoxAdd.Text = "";
            panelAdd.Visible = false;
            panelNow.Enabled = true;
            listBoxBedNumber.Enabled = true;
        }

        //删除当前病人
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxDel.Text.Equals(bedDatas[listBoxBedNumber.SelectedIndex].Get_hospitalNumber()))
            {
                StreamWriter sw = new StreamWriter(dataPath + listBoxBedNumber.Text + ".txt", false, System.Text.Encoding.Default);
                sw.Close();
                bedDatas[listBoxBedNumber.SelectedIndex] = new BedData();
                RefreshAll();
                CheckInfrared();
                CheckBed();
            }
            else
            {
                MessageBox.Show("删除失败，请输入正确的住院号");
            }
        }

        //列表切换
        private void listBoxBedNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelBedNumber.Text = "床位号：" + listBoxBedNumber.Text;
            textBoxDel.Text = "请输入住院号以确认删除";
            if (bedDatas[listBoxBedNumber.SelectedIndex].Get_isEmpty())
            {
                panelNew.Visible = true;
                panelNow.Visible = false;
                return;
            }

            panelNew.Visible = false;
            panelNow.Visible = true;
            labelHospitalNumber.Text = "住院号：\n" + bedDatas[listBoxBedNumber.SelectedIndex].Get_hospitalNumber();
            labelNextTime.Text = "下次操作时间：\n" + bedDatas[listBoxBedNumber.SelectedIndex].Get_nextTime().ToString();
            RefreshBed();
        }

        //刷新床位面板
        private void RefreshBed()
        {
            if (bedDatas[listBoxBedNumber.SelectedIndex].Get_nextTime().ToFileTime() < DateTime.Now.ToFileTime())
            {
                labelDo.ForeColor = Color.Red;
                if (bedDatas[listBoxBedNumber.SelectedIndex].Get_isBlanket())
                {
                    buttonGiveup.Visible = false;
                    labelDo.Text = "操作事项：\n" + "请打开被子,打开后点击确定";
                    buttonBlanket.Visible = true;
                }
                else
                {
                    buttonGiveup.Visible = true;
                    labelDo.Text = "操作事项：\n" + "复制文件名并拍照";
                    buttonBlanket.Visible = false;
                }
            }
            else
            {
                labelDo.ForeColor = Color.Black;
                buttonBlanket.Visible = false;
                if (bedDatas[listBoxBedNumber.SelectedIndex].Get_isBlanket())
                {
                    buttonGiveup.Visible = false;
                    labelDo.Text = "操作事项：\n" + "无";
                }
                else
                {
                    buttonGiveup.Visible = true;
                    labelDo.Text = "操作事项：\n" + "请保持被子打开";
                }
            }
        }
        //刷新全部
        private void RefreshAll()
        {
            listBoxBedNumber.Items[listBoxBedNumber.SelectedIndex] = listBoxBedNumber.Items[listBoxBedNumber.SelectedIndex];
            listBoxBedNumber.Items.Add("");
            listBoxBedNumber.Items.RemoveAt(BedData.totalNum);
        }

        //绘制列表
        private void listBoxBedNumber_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Brush mybsh = Brushes.Black;
                Font myfont = new Font(this.Font.FontFamily, 11);
                if (bedDatas[e.Index].Get_isEmpty())
                {
                    mybsh = Brushes.Gray;
                }
                else if (bedDatas[e.Index].Get_nextTime().ToFileTime() < DateTime.Now.ToFileTime())
                {
                    mybsh = Brushes.Red;
                }
                // 焦点框
                e.DrawFocusRectangle();
                //文本 
                e.Graphics.DrawString(listBoxBedNumber.Items[e.Index].ToString(), myfont, mybsh, e.Bounds, StringFormat.GenericDefault);
            }
        }

        //延迟
        private void buttonDelay_Click(object sender, EventArgs e)
        {
            if (textBoxDelay.Text == "") 
            {
                MessageBox.Show("请输入整数");
            } 
            else if (Regex.IsMatch(textBoxDelay.Text, @"^\d*$"))
            {
                int x = Convert.ToInt32(textBoxDelay.Text);
                if (!bedDatas[listBoxBedNumber.SelectedIndex].Get_isBlanket() && x > 15)
                {
                    MessageBox.Show("无法将拍照延迟15分钟以上，请点击\"放弃本次拍照\"");
                    textBoxDelay.Text = "";
                    return;
                }
                DialogResult result = MessageBox.Show("您确定要延迟" + textBoxDelay.Text + "分钟吗？",
                "延迟操作", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int y = 60 * BedData.timeInterval[bedDatas[listBoxBedNumber.SelectedIndex].Get_disease()];
                    if (x > y)
                    {
                        DialogResult result1 = MessageBox.Show("延迟" + y + "分钟以上会导致数据丢失，您确定吗", "数据丢失", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.No)
                        {
                            textBoxDelay.Text = "";
                            return;
                        }
                    }
                    bedDatas[listBoxBedNumber.SelectedIndex].Delay(x);
                    textBoxDelay.Text = "";
                    RefreshAll();
                    CheckInfrared();
                    CheckBed();
                }
            }
            else
            {
                textBoxDelay.Text = "";
                MessageBox.Show("请输入整数");
            }
        }
        //放弃本次拍照
        private void buttonGiveup_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要放弃本次拍照吗？", "放弃本次拍照", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bedDatas[listBoxBedNumber.SelectedIndex].Giveup();
                RefreshAll();
                CheckBed();
                CheckInfrared();
            }
        }

        //确认热像仪
        private void buttonInfrared_Click(object sender, EventArgs e)
        {
            buttonInfrared.Visible = false;
            if (isOpen)
            {
                isOpen = false;
            }
            else
            {
                isOpen = true;
                openTime = DateTime.Now;
                for (int i = 0; i < BedData.totalNum; i++)
                {
                    if (bedDatas[i].Get_isEmpty())
                    {
                        continue;
                    }
                    if (!bedDatas[i].Get_isBlanket())
                    {
                        long x = openTime.AddMinutes(10).ToFileTime();
                        long y = bedDatas[i].Get_nextTime().ToFileTime();
                        if (y < x)
                        {
                            int z = (int)((x - y) / 600000000 + 1);
                            bedDatas[i].Delay(z);
                        }
                    }
                }
            }
            RefreshAll();
            CheckInfrared();
            CheckBed();
        }

        //静音5分钟
        private void buttonMute_Click(object sender, EventArgs e)
        {
            isMute = true;
            sp.Stop();
            buttonMute.Enabled = false;
            buttonMute.Text = "闹钟已暂停";
            timer3.Enabled = true;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            buttonMute.Enabled = true;
            buttonMute.Text = "暂停闹钟";
            isMute = false;
        }

        //确认被子打开
        private void buttonBlanket_Click(object sender, EventArgs e)
        {
            bedDatas[listBoxBedNumber.SelectedIndex].OpenBlanket(BedData.fileNames[listBoxBedNumber.SelectedIndex]);

            RefreshAll();
            CheckInfrared();
            CheckBed();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Enabled = false;
            buttonCopy.Text = "复制文件名";
            buttonCopy.Enabled = true;
        }

        private void checkBoxBluetooth_CheckedChanged(object sender, EventArgs e)
        {
            CheckOutDevice1();
        }
    }

    //统计
    //音量控制

    class BedData
    {
        public const int totalNum = 20;
        public static int[] timeInterval = new int[] { 4, 2, 2 };
        public static int[] timetotal = new int[] { 72, 24, 24 };
        public static string[] fileNames = new string[totalNum] {
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
            "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };

        private bool isEmpty;
        private string hospitalNumber;
        private int disease;
        private DateTime nextTime;
        private DateTime finishTime;
        private string dataPath;
        private bool isBlanket;
        private string fileName;

        public BedData(string _hospitalNumber, int _disease, DateTime _nextTime, DateTime _finishTime, string _dataPath, string _fileName)
        {
            isEmpty = false;
            hospitalNumber = _hospitalNumber;
            disease = _disease;
            nextTime = _nextTime;
            finishTime = _finishTime;
            dataPath = _dataPath;
            isBlanket = true;
            fileName = _fileName;
        }

        public BedData()
        {
            isEmpty = true;
        }

        public string Get_hospitalNumber()
        {
            return hospitalNumber;
        }

        public DateTime Get_nextTime()
        {
            return nextTime;
        }

        public DateTime Get_finishTime()
        {
            return finishTime;
        }

        public int Get_disease()
        {
            return disease;
        }

        public bool Get_isEmpty()
        {
            return isEmpty;
        }

        public bool Get_isBlanket()
        {
            return isBlanket;
        }

        public void Set_isBlanket(bool _isBlanket)
        {
            isBlanket = _isBlanket;
        }

        public void Delay(int minuteNum)
        {
            nextTime = nextTime.AddMinutes(minuteNum);
            StreamWriter sw = new StreamWriter(dataPath + fileName + ".txt", false, Encoding.Default);
            sw.WriteLine(hospitalNumber);//住院号
            sw.WriteLine(disease.ToString());//疾病种类
            sw.WriteLine(nextTime.ToFileTime().ToString());//下一次操作时间
            sw.WriteLine(finishTime.ToFileTime().ToString());//结束时间
            sw.Close();
        }

        public void OpenBlanket(string _fileName)
        {
            isBlanket = false;
            nextTime = DateTime.Now.AddMinutes(15);
            StreamWriter sw = new StreamWriter(dataPath + fileName + ".txt", false, Encoding.Default);
            sw.WriteLine(hospitalNumber);//住院号
            sw.WriteLine(disease.ToString());//疾病种类
            sw.WriteLine(nextTime.ToFileTime().ToString());//下一次操作时间
            sw.WriteLine(finishTime.ToFileTime().ToString());//结束时间
            sw.Close();
        }

        public void Next(string _fileName)
        {
            int hour = (DateTime.Now.Hour + 2) / timeInterval[disease] * timeInterval[disease] - 2 + timeInterval[disease];
            nextTime = DateTime.Now.Date.AddHours(hour).AddMinutes(-15);
            isBlanket = true;
            StreamWriter sw = new StreamWriter(dataPath + _fileName + ".txt", false, Encoding.Default);
            sw.WriteLine(hospitalNumber);//住院号
            sw.WriteLine(disease.ToString());//疾病种类
            sw.WriteLine(nextTime.ToFileTime().ToString());//下一次操作时间
            sw.WriteLine(finishTime.ToFileTime().ToString());//结束时间
            sw.Close();
        }

        public void Giveup()
        {
            isBlanket = true;
            nextTime = DateTime.Now;
        }
    }
}
