namespace IcuInfrared
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.listBoxBedNumber = new System.Windows.Forms.ListBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.panelNew = new System.Windows.Forms.Panel();
            this.comboBoxDisease = new System.Windows.Forms.ComboBox();
            this.textBoxNewHospitalNumber = new System.Windows.Forms.TextBox();
            this.labelDisease = new System.Windows.Forms.Label();
            this.labelNewHospitalNumber = new System.Windows.Forms.Label();
            this.labelBedNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxDel = new System.Windows.Forms.TextBox();
            this.panelNow = new System.Windows.Forms.Panel();
            this.panelDel = new System.Windows.Forms.Panel();
            this.panelHospitalNumber = new System.Windows.Forms.Panel();
            this.labelHospitalNumber = new System.Windows.Forms.Label();
            this.panelDo = new System.Windows.Forms.Panel();
            this.textBoxRespond = new System.Windows.Forms.TextBox();
            this.labelRespond = new System.Windows.Forms.Label();
            this.buttonBlanket = new System.Windows.Forms.Button();
            this.labelDo = new System.Windows.Forms.Label();
            this.panelNextTime = new System.Windows.Forms.Panel();
            this.buttonGiveup = new System.Windows.Forms.Button();
            this.labelDelay = new System.Windows.Forms.Label();
            this.textBoxDelay = new System.Windows.Forms.TextBox();
            this.labelNextTime = new System.Windows.Forms.Label();
            this.buttonDelay = new System.Windows.Forms.Button();
            this.buttonMute = new System.Windows.Forms.Button();
            this.panelInfrared = new System.Windows.Forms.Panel();
            this.labelInfraredTime = new System.Windows.Forms.Label();
            this.buttonInfrared = new System.Windows.Forms.Button();
            this.labelInfraredDo = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelComputer = new System.Windows.Forms.Panel();
            this.labelComputerDo = new System.Windows.Forms.Label();
            this.labelComputer = new System.Windows.Forms.Label();
            this.panelBluetooth = new System.Windows.Forms.Panel();
            this.checkBoxBluetooth = new System.Windows.Forms.CheckBox();
            this.labelBluetoothDo = new System.Windows.Forms.Label();
            this.labelBluetooth = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAddCancel = new System.Windows.Forms.Button();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.labelAdd = new System.Windows.Forms.Label();
            this.panelNew.SuspendLayout();
            this.panelNow.SuspendLayout();
            this.panelDel.SuspendLayout();
            this.panelHospitalNumber.SuspendLayout();
            this.panelDo.SuspendLayout();
            this.panelNextTime.SuspendLayout();
            this.panelInfrared.SuspendLayout();
            this.panelComputer.SuspendLayout();
            this.panelBluetooth.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNew.Location = new System.Drawing.Point(8, 165);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(346, 48);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "新病人入组";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.AutoSize = true;
            this.buttonDel.Location = new System.Drawing.Point(196, 3);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(117, 25);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "删除当前病人";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // listBoxBedNumber
            // 
            this.listBoxBedNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBedNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxBedNumber.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxBedNumber.FormattingEnabled = true;
            this.listBoxBedNumber.ItemHeight = 20;
            this.listBoxBedNumber.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.listBoxBedNumber.Location = new System.Drawing.Point(12, 12);
            this.listBoxBedNumber.Name = "listBoxBedNumber";
            this.listBoxBedNumber.Size = new System.Drawing.Size(101, 524);
            this.listBoxBedNumber.TabIndex = 2;
            this.listBoxBedNumber.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxBedNumber_DrawItem);
            this.listBoxBedNumber.SelectedIndexChanged += new System.EventHandler(this.listBoxBedNumber_SelectedIndexChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.ForeColor = System.Drawing.Color.Black;
            this.buttonCopy.Location = new System.Drawing.Point(178, 39);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(117, 48);
            this.buttonCopy.TabIndex = 3;
            this.buttonCopy.Text = "复制文件名";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // panelNew
            // 
            this.panelNew.BackColor = System.Drawing.SystemColors.Window;
            this.panelNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNew.Controls.Add(this.comboBoxDisease);
            this.panelNew.Controls.Add(this.textBoxNewHospitalNumber);
            this.panelNew.Controls.Add(this.labelDisease);
            this.panelNew.Controls.Add(this.labelNewHospitalNumber);
            this.panelNew.Controls.Add(this.buttonNew);
            this.panelNew.Location = new System.Drawing.Point(142, 138);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(366, 230);
            this.panelNew.TabIndex = 4;
            // 
            // comboBoxDisease
            // 
            this.comboBoxDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisease.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDisease.FormattingEnabled = true;
            this.comboBoxDisease.Items.AddRange(new object[] {
            "中枢神经损伤",
            "脓毒症",
            "心脏手术"});
            this.comboBoxDisease.Location = new System.Drawing.Point(116, 81);
            this.comboBoxDisease.Name = "comboBoxDisease";
            this.comboBoxDisease.Size = new System.Drawing.Size(238, 31);
            this.comboBoxDisease.TabIndex = 6;
            // 
            // textBoxNewHospitalNumber
            // 
            this.textBoxNewHospitalNumber.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNewHospitalNumber.Location = new System.Drawing.Point(116, 12);
            this.textBoxNewHospitalNumber.Name = "textBoxNewHospitalNumber";
            this.textBoxNewHospitalNumber.Size = new System.Drawing.Size(238, 34);
            this.textBoxNewHospitalNumber.TabIndex = 4;
            // 
            // labelDisease
            // 
            this.labelDisease.AutoSize = true;
            this.labelDisease.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDisease.Location = new System.Drawing.Point(4, 88);
            this.labelDisease.Name = "labelDisease";
            this.labelDisease.Size = new System.Drawing.Size(106, 24);
            this.labelDisease.TabIndex = 3;
            this.labelDisease.Text = "疾病类型";
            // 
            // labelNewHospitalNumber
            // 
            this.labelNewHospitalNumber.AutoSize = true;
            this.labelNewHospitalNumber.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNewHospitalNumber.Location = new System.Drawing.Point(4, 22);
            this.labelNewHospitalNumber.Name = "labelNewHospitalNumber";
            this.labelNewHospitalNumber.Size = new System.Drawing.Size(82, 24);
            this.labelNewHospitalNumber.TabIndex = 1;
            this.labelNewHospitalNumber.Text = "住院号";
            // 
            // labelBedNumber
            // 
            this.labelBedNumber.AutoSize = true;
            this.labelBedNumber.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBedNumber.Location = new System.Drawing.Point(201, 12);
            this.labelBedNumber.Name = "labelBedNumber";
            this.labelBedNumber.Size = new System.Drawing.Size(235, 43);
            this.labelBedNumber.TabIndex = 2;
            this.labelBedNumber.Text = "床位号：01";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxDel
            // 
            this.textBoxDel.Location = new System.Drawing.Point(3, 3);
            this.textBoxDel.Name = "textBoxDel";
            this.textBoxDel.Size = new System.Drawing.Size(189, 25);
            this.textBoxDel.TabIndex = 6;
            this.textBoxDel.Text = "请输入住院号以确认删除";
            // 
            // panelNow
            // 
            this.panelNow.BackColor = System.Drawing.SystemColors.Window;
            this.panelNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNow.Controls.Add(this.panelDel);
            this.panelNow.Controls.Add(this.panelHospitalNumber);
            this.panelNow.Controls.Add(this.panelDo);
            this.panelNow.Controls.Add(this.panelNextTime);
            this.panelNow.Location = new System.Drawing.Point(151, 87);
            this.panelNow.Name = "panelNow";
            this.panelNow.Size = new System.Drawing.Size(346, 448);
            this.panelNow.TabIndex = 7;
            // 
            // panelDel
            // 
            this.panelDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDel.Controls.Add(this.textBoxDel);
            this.panelDel.Controls.Add(this.buttonDel);
            this.panelDel.Location = new System.Drawing.Point(12, 379);
            this.panelDel.Name = "panelDel";
            this.panelDel.Size = new System.Drawing.Size(318, 40);
            this.panelDel.TabIndex = 12;
            // 
            // panelHospitalNumber
            // 
            this.panelHospitalNumber.BackColor = System.Drawing.SystemColors.Info;
            this.panelHospitalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHospitalNumber.Controls.Add(this.labelHospitalNumber);
            this.panelHospitalNumber.Location = new System.Drawing.Point(12, 11);
            this.panelHospitalNumber.Name = "panelHospitalNumber";
            this.panelHospitalNumber.Size = new System.Drawing.Size(318, 71);
            this.panelHospitalNumber.TabIndex = 11;
            // 
            // labelHospitalNumber
            // 
            this.labelHospitalNumber.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHospitalNumber.Location = new System.Drawing.Point(3, 2);
            this.labelHospitalNumber.Name = "labelHospitalNumber";
            this.labelHospitalNumber.Size = new System.Drawing.Size(183, 56);
            this.labelHospitalNumber.TabIndex = 7;
            this.labelHospitalNumber.Text = "住院号：";
            // 
            // panelDo
            // 
            this.panelDo.BackColor = System.Drawing.SystemColors.Info;
            this.panelDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDo.Controls.Add(this.textBoxRespond);
            this.panelDo.Controls.Add(this.labelRespond);
            this.panelDo.Controls.Add(this.buttonBlanket);
            this.panelDo.Controls.Add(this.buttonCopy);
            this.panelDo.Controls.Add(this.labelDo);
            this.panelDo.Location = new System.Drawing.Point(12, 203);
            this.panelDo.Name = "panelDo";
            this.panelDo.Size = new System.Drawing.Size(318, 157);
            this.panelDo.TabIndex = 10;
            // 
            // textBoxRespond
            // 
            this.textBoxRespond.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRespond.Location = new System.Drawing.Point(86, 103);
            this.textBoxRespond.Name = "textBoxRespond";
            this.textBoxRespond.Size = new System.Drawing.Size(209, 38);
            this.textBoxRespond.TabIndex = 13;
            // 
            // labelRespond
            // 
            this.labelRespond.AutoSize = true;
            this.labelRespond.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRespond.Location = new System.Drawing.Point(6, 109);
            this.labelRespond.Name = "labelRespond";
            this.labelRespond.Size = new System.Drawing.Size(82, 24);
            this.labelRespond.TabIndex = 12;
            this.labelRespond.Text = "工号：";
            // 
            // buttonBlanket
            // 
            this.buttonBlanket.ForeColor = System.Drawing.Color.Red;
            this.buttonBlanket.Location = new System.Drawing.Point(178, 3);
            this.buttonBlanket.Name = "buttonBlanket";
            this.buttonBlanket.Size = new System.Drawing.Size(117, 30);
            this.buttonBlanket.TabIndex = 11;
            this.buttonBlanket.Text = "确定";
            this.buttonBlanket.UseVisualStyleBackColor = true;
            this.buttonBlanket.Click += new System.EventHandler(this.buttonBlanket_Click);
            // 
            // labelDo
            // 
            this.labelDo.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDo.Location = new System.Drawing.Point(3, 2);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(162, 85);
            this.labelDo.TabIndex = 10;
            this.labelDo.Text = "操作事项：";
            // 
            // panelNextTime
            // 
            this.panelNextTime.BackColor = System.Drawing.SystemColors.Info;
            this.panelNextTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNextTime.Controls.Add(this.buttonGiveup);
            this.panelNextTime.Controls.Add(this.labelDelay);
            this.panelNextTime.Controls.Add(this.textBoxDelay);
            this.panelNextTime.Controls.Add(this.labelNextTime);
            this.panelNextTime.Controls.Add(this.buttonDelay);
            this.panelNextTime.Location = new System.Drawing.Point(12, 97);
            this.panelNextTime.Name = "panelNextTime";
            this.panelNextTime.Size = new System.Drawing.Size(318, 89);
            this.panelNextTime.TabIndex = 8;
            // 
            // buttonGiveup
            // 
            this.buttonGiveup.Location = new System.Drawing.Point(178, 41);
            this.buttonGiveup.Name = "buttonGiveup";
            this.buttonGiveup.Size = new System.Drawing.Size(117, 28);
            this.buttonGiveup.TabIndex = 14;
            this.buttonGiveup.Text = "放弃本次拍照";
            this.buttonGiveup.UseVisualStyleBackColor = true;
            this.buttonGiveup.Click += new System.EventHandler(this.buttonGiveup_Click);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(276, 8);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(37, 15);
            this.labelDelay.TabIndex = 13;
            this.labelDelay.Text = "分钟";
            // 
            // textBoxDelay
            // 
            this.textBoxDelay.Location = new System.Drawing.Point(236, 3);
            this.textBoxDelay.Name = "textBoxDelay";
            this.textBoxDelay.Size = new System.Drawing.Size(38, 25);
            this.textBoxDelay.TabIndex = 12;
            // 
            // labelNextTime
            // 
            this.labelNextTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNextTime.Location = new System.Drawing.Point(2, 2);
            this.labelNextTime.Name = "labelNextTime";
            this.labelNextTime.Size = new System.Drawing.Size(163, 71);
            this.labelNextTime.TabIndex = 9;
            this.labelNextTime.Text = "下次操作时间：";
            // 
            // buttonDelay
            // 
            this.buttonDelay.Location = new System.Drawing.Point(178, 3);
            this.buttonDelay.Name = "buttonDelay";
            this.buttonDelay.Size = new System.Drawing.Size(55, 25);
            this.buttonDelay.TabIndex = 9;
            this.buttonDelay.Text = "延迟";
            this.buttonDelay.UseVisualStyleBackColor = true;
            this.buttonDelay.Click += new System.EventHandler(this.buttonDelay_Click);
            // 
            // buttonMute
            // 
            this.buttonMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonMute.Location = new System.Drawing.Point(542, 12);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(228, 43);
            this.buttonMute.TabIndex = 12;
            this.buttonMute.Text = "暂停闹钟";
            this.buttonMute.UseVisualStyleBackColor = false;
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);
            // 
            // panelInfrared
            // 
            this.panelInfrared.BackColor = System.Drawing.SystemColors.Window;
            this.panelInfrared.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfrared.Controls.Add(this.labelInfraredTime);
            this.panelInfrared.Controls.Add(this.buttonInfrared);
            this.panelInfrared.Controls.Add(this.labelInfraredDo);
            this.panelInfrared.Controls.Add(this.labelEquipment);
            this.panelInfrared.Location = new System.Drawing.Point(542, 194);
            this.panelInfrared.Name = "panelInfrared";
            this.panelInfrared.Size = new System.Drawing.Size(228, 202);
            this.panelInfrared.TabIndex = 8;
            // 
            // labelInfraredTime
            // 
            this.labelInfraredTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfraredTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfraredTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInfraredTime.Location = new System.Drawing.Point(-1, 36);
            this.labelInfraredTime.Name = "labelInfraredTime";
            this.labelInfraredTime.Size = new System.Drawing.Size(228, 60);
            this.labelInfraredTime.TabIndex = 6;
            // 
            // buttonInfrared
            // 
            this.buttonInfrared.AutoSize = true;
            this.buttonInfrared.Location = new System.Drawing.Point(148, 172);
            this.buttonInfrared.Name = "buttonInfrared";
            this.buttonInfrared.Size = new System.Drawing.Size(75, 25);
            this.buttonInfrared.TabIndex = 5;
            this.buttonInfrared.Text = "确定";
            this.buttonInfrared.UseVisualStyleBackColor = true;
            this.buttonInfrared.Visible = false;
            this.buttonInfrared.Click += new System.EventHandler(this.buttonInfrared_Click);
            // 
            // labelInfraredDo
            // 
            this.labelInfraredDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfraredDo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInfraredDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelInfraredDo.Location = new System.Drawing.Point(-1, 113);
            this.labelInfraredDo.Name = "labelInfraredDo";
            this.labelInfraredDo.Size = new System.Drawing.Size(228, 60);
            this.labelInfraredDo.TabIndex = 4;
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEquipment.Location = new System.Drawing.Point(47, 0);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(96, 28);
            this.labelEquipment.TabIndex = 3;
            this.labelEquipment.Text = "热像仪";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 300000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panelComputer
            // 
            this.panelComputer.BackColor = System.Drawing.SystemColors.Window;
            this.panelComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelComputer.Controls.Add(this.labelComputerDo);
            this.panelComputer.Controls.Add(this.labelComputer);
            this.panelComputer.Location = new System.Drawing.Point(542, 416);
            this.panelComputer.Name = "panelComputer";
            this.panelComputer.Size = new System.Drawing.Size(228, 119);
            this.panelComputer.TabIndex = 14;
            // 
            // labelComputerDo
            // 
            this.labelComputerDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComputerDo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelComputerDo.ForeColor = System.Drawing.Color.Red;
            this.labelComputerDo.Location = new System.Drawing.Point(-1, 42);
            this.labelComputerDo.Name = "labelComputerDo";
            this.labelComputerDo.Size = new System.Drawing.Size(228, 73);
            this.labelComputerDo.TabIndex = 4;
            // 
            // labelComputer
            // 
            this.labelComputer.AutoSize = true;
            this.labelComputer.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelComputer.Location = new System.Drawing.Point(65, -1);
            this.labelComputer.Name = "labelComputer";
            this.labelComputer.Size = new System.Drawing.Size(68, 28);
            this.labelComputer.TabIndex = 3;
            this.labelComputer.Text = "电脑";
            // 
            // panelBluetooth
            // 
            this.panelBluetooth.BackColor = System.Drawing.SystemColors.Window;
            this.panelBluetooth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBluetooth.Controls.Add(this.checkBoxBluetooth);
            this.panelBluetooth.Controls.Add(this.labelBluetoothDo);
            this.panelBluetooth.Controls.Add(this.labelBluetooth);
            this.panelBluetooth.Location = new System.Drawing.Point(542, 87);
            this.panelBluetooth.Name = "panelBluetooth";
            this.panelBluetooth.Size = new System.Drawing.Size(228, 91);
            this.panelBluetooth.TabIndex = 16;
            // 
            // checkBoxBluetooth
            // 
            this.checkBoxBluetooth.AutoSize = true;
            this.checkBoxBluetooth.Location = new System.Drawing.Point(3, 67);
            this.checkBoxBluetooth.Name = "checkBoxBluetooth";
            this.checkBoxBluetooth.Size = new System.Drawing.Size(119, 19);
            this.checkBoxBluetooth.TabIndex = 5;
            this.checkBoxBluetooth.Text = "启用蓝牙音箱";
            this.checkBoxBluetooth.UseVisualStyleBackColor = true;
            this.checkBoxBluetooth.CheckedChanged += new System.EventHandler(this.checkBoxBluetooth_CheckedChanged);
            // 
            // labelBluetoothDo
            // 
            this.labelBluetoothDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBluetoothDo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBluetoothDo.ForeColor = System.Drawing.Color.Red;
            this.labelBluetoothDo.Location = new System.Drawing.Point(-1, 41);
            this.labelBluetoothDo.Name = "labelBluetoothDo";
            this.labelBluetoothDo.Size = new System.Drawing.Size(228, 29);
            this.labelBluetoothDo.TabIndex = 4;
            // 
            // labelBluetooth
            // 
            this.labelBluetooth.AutoSize = true;
            this.labelBluetooth.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBluetooth.Location = new System.Drawing.Point(47, -1);
            this.labelBluetooth.Name = "labelBluetooth";
            this.labelBluetooth.Size = new System.Drawing.Size(124, 28);
            this.labelBluetooth.TabIndex = 3;
            this.labelBluetooth.Text = "蓝牙音箱";
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAdd.Controls.Add(this.buttonAddCancel);
            this.panelAdd.Controls.Add(this.buttonAddOk);
            this.panelAdd.Controls.Add(this.textBoxAdd);
            this.panelAdd.Controls.Add(this.labelAdd);
            this.panelAdd.Location = new System.Drawing.Point(129, 212);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(390, 152);
            this.panelAdd.TabIndex = 17;
            this.panelAdd.Visible = false;
            // 
            // buttonAddCancel
            // 
            this.buttonAddCancel.Location = new System.Drawing.Point(235, 106);
            this.buttonAddCancel.Name = "buttonAddCancel";
            this.buttonAddCancel.Size = new System.Drawing.Size(100, 34);
            this.buttonAddCancel.TabIndex = 3;
            this.buttonAddCancel.Text = "取消加拍";
            this.buttonAddCancel.UseVisualStyleBackColor = true;
            this.buttonAddCancel.Click += new System.EventHandler(this.buttonAddCancel_Click);
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Location = new System.Drawing.Point(64, 106);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(100, 34);
            this.buttonAddOk.TabIndex = 2;
            this.buttonAddOk.Text = "确定加拍";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(3, 75);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(383, 25);
            this.textBoxAdd.TabIndex = 1;
            // 
            // labelAdd
            // 
            this.labelAdd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAdd.Location = new System.Drawing.Point(-1, 8);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(391, 53);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "正式拍照应在红字提示拍照时进行，此时拍照为加拍，请输入加拍原因:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 593);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelBluetooth);
            this.Controls.Add(this.panelComputer);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.panelNow);
            this.Controls.Add(this.listBoxBedNumber);
            this.Controls.Add(this.panelInfrared);
            this.Controls.Add(this.labelBedNumber);
            this.Controls.Add(this.panelNew);
            this.Name = "Form1";
            this.Text = "红外测温";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelNew.ResumeLayout(false);
            this.panelNew.PerformLayout();
            this.panelNow.ResumeLayout(false);
            this.panelDel.ResumeLayout(false);
            this.panelDel.PerformLayout();
            this.panelHospitalNumber.ResumeLayout(false);
            this.panelDo.ResumeLayout(false);
            this.panelDo.PerformLayout();
            this.panelNextTime.ResumeLayout(false);
            this.panelNextTime.PerformLayout();
            this.panelInfrared.ResumeLayout(false);
            this.panelInfrared.PerformLayout();
            this.panelComputer.ResumeLayout(false);
            this.panelComputer.PerformLayout();
            this.panelBluetooth.ResumeLayout(false);
            this.panelBluetooth.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ListBox listBoxBedNumber;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.Label labelBedNumber;
        private System.Windows.Forms.Label labelNewHospitalNumber;
        private System.Windows.Forms.ComboBox comboBoxDisease;
        private System.Windows.Forms.TextBox textBoxNewHospitalNumber;
        private System.Windows.Forms.Label labelDisease;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxDel;
        private System.Windows.Forms.Panel panelNow;
        private System.Windows.Forms.Label labelHospitalNumber;
        private System.Windows.Forms.Panel panelNextTime;
        private System.Windows.Forms.Button buttonDelay;
        private System.Windows.Forms.Panel panelInfrared;
        private System.Windows.Forms.Button buttonInfrared;
        private System.Windows.Forms.Label labelInfraredDo;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Label labelNextTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel panelComputer;
        private System.Windows.Forms.Label labelComputerDo;
        private System.Windows.Forms.Label labelComputer;
        private System.Windows.Forms.Panel panelDo;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.Button buttonBlanket;
        private System.Windows.Forms.Panel panelDel;
        private System.Windows.Forms.Panel panelHospitalNumber;
        private System.Windows.Forms.Label labelInfraredTime;
        private System.Windows.Forms.Panel panelBluetooth;
        private System.Windows.Forms.Label labelBluetoothDo;
        private System.Windows.Forms.Label labelBluetooth;
        private System.Windows.Forms.TextBox textBoxDelay;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.TextBox textBoxRespond;
        private System.Windows.Forms.Label labelRespond;
        private System.Windows.Forms.Button buttonGiveup;
        private System.Windows.Forms.CheckBox checkBoxBluetooth;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonAddCancel;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Label labelAdd;
    }
}

