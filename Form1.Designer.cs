namespace SerialProMon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbbComPort = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grbCMD = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxDTR = new System.Windows.Forms.CheckBox();
            this.cbxRTS = new System.Windows.Forms.CheckBox();
            this.grbConfig = new System.Windows.Forms.GroupBox();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbHandshake = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDatasize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxHexmode = new System.Windows.Forms.CheckBox();
            this.cbShowTimestamp = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.grbCMD.SuspendLayout();
            this.grbConfig.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(823, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(845, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(845, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(823, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(845, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(12, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(823, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(845, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(12, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(823, 20);
            this.textBox4.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(845, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Send";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(12, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(823, 20);
            this.textBox5.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(845, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Send";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(12, 149);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(823, 20);
            this.textBox6.TabIndex = 11;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 45);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbbComPort
            // 
            this.cbbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbComPort.FormattingEnabled = true;
            this.cbbComPort.Location = new System.Drawing.Point(14, 38);
            this.cbbComPort.Name = "cbbComPort";
            this.cbbComPort.Size = new System.Drawing.Size(105, 21);
            this.cbbComPort.TabIndex = 22;
            this.cbbComPort.SelectedIndexChanged += new System.EventHandler(this.cbbComPort_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(995, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel2.Text = "Tester";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM8";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // grbCMD
            // 
            this.grbCMD.Controls.Add(this.checkBox6);
            this.grbCMD.Controls.Add(this.checkBox5);
            this.grbCMD.Controls.Add(this.checkBox4);
            this.grbCMD.Controls.Add(this.checkBox3);
            this.grbCMD.Controls.Add(this.checkBox2);
            this.grbCMD.Controls.Add(this.checkBox1);
            this.grbCMD.Controls.Add(this.textBox1);
            this.grbCMD.Controls.Add(this.button1);
            this.grbCMD.Controls.Add(this.textBox2);
            this.grbCMD.Controls.Add(this.button2);
            this.grbCMD.Controls.Add(this.textBox3);
            this.grbCMD.Controls.Add(this.button6);
            this.grbCMD.Controls.Add(this.textBox4);
            this.grbCMD.Controls.Add(this.button5);
            this.grbCMD.Controls.Add(this.textBox5);
            this.grbCMD.Controls.Add(this.button3);
            this.grbCMD.Controls.Add(this.textBox6);
            this.grbCMD.Controls.Add(this.button4);
            this.grbCMD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbCMD.Location = new System.Drawing.Point(0, 406);
            this.grbCMD.Name = "grbCMD";
            this.grbCMD.Size = new System.Drawing.Size(995, 179);
            this.grbCMD.TabIndex = 36;
            this.grbCMD.TabStop = false;
            this.grbCMD.Text = "Send";
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(928, 151);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(48, 17);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "HEX";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(928, 125);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 17);
            this.checkBox5.TabIndex = 17;
            this.checkBox5.Text = "HEX";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(928, 99);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 17);
            this.checkBox4.TabIndex = 16;
            this.checkBox4.Text = "HEX";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(928, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "HEX";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(928, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "HEX";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(928, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "HEX";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cbbBaudRate.Location = new System.Drawing.Point(14, 87);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(105, 21);
            this.cbbBaudRate.TabIndex = 37;
            this.cbbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbbBaudRate_SelectedIndexChanged);
            // 
            // cbxDTR
            // 
            this.cbxDTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxDTR.AutoSize = true;
            this.cbxDTR.Location = new System.Drawing.Point(732, 387);
            this.cbxDTR.Name = "cbxDTR";
            this.cbxDTR.Size = new System.Drawing.Size(49, 17);
            this.cbxDTR.TabIndex = 38;
            this.cbxDTR.Text = "DTR";
            this.cbxDTR.UseVisualStyleBackColor = true;
            this.cbxDTR.CheckedChanged += new System.EventHandler(this.cbxDTR_CheckedChanged);
            // 
            // cbxRTS
            // 
            this.cbxRTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRTS.AutoSize = true;
            this.cbxRTS.Location = new System.Drawing.Point(787, 387);
            this.cbxRTS.Name = "cbxRTS";
            this.cbxRTS.Size = new System.Drawing.Size(48, 17);
            this.cbxRTS.TabIndex = 39;
            this.cbxRTS.Text = "RTS";
            this.cbxRTS.UseVisualStyleBackColor = true;
            this.cbxRTS.CheckedChanged += new System.EventHandler(this.cbxRTS_CheckedChanged);
            // 
            // grbConfig
            // 
            this.grbConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbConfig.Controls.Add(this.cbbStopBits);
            this.grbConfig.Controls.Add(this.label7);
            this.grbConfig.Controls.Add(this.cbbHandshake);
            this.grbConfig.Controls.Add(this.label5);
            this.grbConfig.Controls.Add(this.cbbParity);
            this.grbConfig.Controls.Add(this.label4);
            this.grbConfig.Controls.Add(this.cbbDatasize);
            this.grbConfig.Controls.Add(this.label3);
            this.grbConfig.Controls.Add(this.label2);
            this.grbConfig.Controls.Add(this.label1);
            this.grbConfig.Controls.Add(this.cbbComPort);
            this.grbConfig.Controls.Add(this.cbbBaudRate);
            this.grbConfig.Location = new System.Drawing.Point(850, 14);
            this.grbConfig.Name = "grbConfig";
            this.grbConfig.Size = new System.Drawing.Size(133, 329);
            this.grbConfig.TabIndex = 40;
            this.grbConfig.TabStop = false;
            this.grbConfig.Text = "Serial Port";
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.cbbStopBits.Location = new System.Drawing.Point(14, 190);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(105, 21);
            this.cbbStopBits.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Stop Bits";
            // 
            // cbbHandshake
            // 
            this.cbbHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHandshake.FormattingEnabled = true;
            this.cbbHandshake.Items.AddRange(new object[] {
            "OFF",
            "RTS",
            "Xon/Xoff",
            "RTS+Xon/Xoff"});
            this.cbbHandshake.Location = new System.Drawing.Point(14, 291);
            this.cbbHandshake.Name = "cbbHandshake";
            this.cbbHandshake.Size = new System.Drawing.Size(105, 21);
            this.cbbHandshake.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Handshake";
            // 
            // cbbParity
            // 
            this.cbbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbParity.FormattingEnabled = true;
            this.cbbParity.Items.AddRange(new object[] {
            "none",
            "even",
            "odd",
            "mark"});
            this.cbbParity.Location = new System.Drawing.Point(14, 240);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(105, 21);
            this.cbbParity.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Parity";
            // 
            // cbbDatasize
            // 
            this.cbbDatasize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDatasize.FormattingEnabled = true;
            this.cbbDatasize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cbbDatasize.Location = new System.Drawing.Point(14, 139);
            this.cbbDatasize.Name = "cbbDatasize";
            this.cbbDatasize.Size = new System.Drawing.Size(105, 21);
            this.cbbDatasize.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Baudrate (bps)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(817, 344);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 350);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Received/Sent data";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnConnect, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(862, 350);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 54);
            this.tableLayoutPanel2.TabIndex = 43;
            // 
            // cbxHexmode
            // 
            this.cbxHexmode.AutoSize = true;
            this.cbxHexmode.Location = new System.Drawing.Point(128, 13);
            this.cbxHexmode.Name = "cbxHexmode";
            this.cbxHexmode.Size = new System.Drawing.Size(75, 17);
            this.cbxHexmode.TabIndex = 44;
            this.cbxHexmode.Text = "Hex Mode";
            this.cbxHexmode.UseVisualStyleBackColor = true;
            this.cbxHexmode.CheckedChanged += new System.EventHandler(this.cbxHexmode_CheckedChanged);
            // 
            // cbShowTimestamp
            // 
            this.cbShowTimestamp.AutoSize = true;
            this.cbShowTimestamp.Location = new System.Drawing.Point(209, 13);
            this.cbShowTimestamp.Name = "cbShowTimestamp";
            this.cbShowTimestamp.Size = new System.Drawing.Size(103, 17);
            this.cbShowTimestamp.TabIndex = 45;
            this.cbShowTimestamp.Text = "Show timestamp";
            this.cbShowTimestamp.UseVisualStyleBackColor = true;
            this.cbShowTimestamp.CheckedChanged += new System.EventHandler(this.cbShowTimestamp_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 607);
            this.Controls.Add(this.cbShowTimestamp);
            this.Controls.Add(this.cbxHexmode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cbxRTS);
            this.Controls.Add(this.grbCMD);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbxDTR);
            this.Controls.Add(this.grbConfig);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(290, 640);
            this.Name = "Form1";
            this.Text = "Serial Monitor Professional by TTLong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbCMD.ResumeLayout(false);
            this.grbCMD.PerformLayout();
            this.grbConfig.ResumeLayout(false);
            this.grbConfig.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbbComPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox grbCMD;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.CheckBox cbxDTR;
        private System.Windows.Forms.CheckBox cbxRTS;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grbConfig;
        private System.Windows.Forms.ComboBox cbbHandshake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDatasize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cbxHexmode;
        private System.Windows.Forms.CheckBox cbShowTimestamp;
        private System.Windows.Forms.Timer timer1;
    }
}

