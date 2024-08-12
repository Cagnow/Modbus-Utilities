namespace Modbus_Utilities
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TextBoxIP = new TextBox();
            btConnect = new Button();
            label1 = new Label();
            Status = new Label();
            PortTextBox = new TextBox();
            StatusModbus = new System.Windows.Forms.Timer(components);
            btDisconnect = new Button();
            ReadModbus = new System.Windows.Forms.Timer(components);
            btDecimal = new RadioButton();
            btHexadecimal = new RadioButton();
            label2 = new Label();
            StartAddressTextBox = new TextBox();
            NoRegisterTextBox = new TextBox();
            ReadModeComboBox = new ComboBox();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ModbusExceptionTextBox = new TextBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            MaxClientTextBox = new TextBox();
            TimeoutTextBox = new TextBox();
            StopServer = new Button();
            StartServ = new Button();
            IPtextBoxServ = new TextBox();
            StatusServer = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxIP
            // 
            TextBoxIP.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxIP.Location = new Point(21, 345);
            TextBoxIP.Name = "TextBoxIP";
            TextBoxIP.PlaceholderText = "IP";
            TextBoxIP.Size = new Size(155, 32);
            TextBoxIP.TabIndex = 0;
            TextBoxIP.TextChanged += IpTextBox;
            // 
            // btConnect
            // 
            btConnect.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btConnect.Location = new Point(31, 420);
            btConnect.Name = "btConnect";
            btConnect.Size = new Size(155, 36);
            btConnect.TabIndex = 1;
            btConnect.Text = "Connect";
            btConnect.UseVisualStyleBackColor = true;
            btConnect.Click += btConnection;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 2;
            label1.Text = "Status :";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Status.ForeColor = Color.Red;
            Status.Location = new Point(85, 18);
            Status.Name = "Status";
            Status.Size = new Size(136, 25);
            Status.TabIndex = 3;
            Status.Text = "Not connected";
            // 
            // PortTextBox
            // 
            PortTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PortTextBox.Location = new Point(199, 345);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.PlaceholderText = "Port";
            PortTextBox.Size = new Size(100, 32);
            PortTextBox.TabIndex = 4;
            PortTextBox.TextChanged += PortTextBox_TextChanged;
            // 
            // StatusModbus
            // 
            StatusModbus.Tag = "true";
            StatusModbus.Tick += timer1_Tick;
            // 
            // btDisconnect
            // 
            btDisconnect.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btDisconnect.Location = new Point(31, 462);
            btDisconnect.Name = "btDisconnect";
            btDisconnect.Size = new Size(155, 36);
            btDisconnect.TabIndex = 5;
            btDisconnect.Text = "Disconnect";
            btDisconnect.UseVisualStyleBackColor = true;
            btDisconnect.Click += btDisconnect_Click;
            // 
            // ReadModbus
            // 
            ReadModbus.Tick += timer1_Tick_1;
            // 
            // btDecimal
            // 
            btDecimal.AutoSize = true;
            btDecimal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btDecimal.Location = new Point(688, 18);
            btDecimal.Name = "btDecimal";
            btDecimal.Size = new Size(98, 29);
            btDecimal.TabIndex = 6;
            btDecimal.TabStop = true;
            btDecimal.Text = "Decimal";
            btDecimal.UseVisualStyleBackColor = true;
            btDecimal.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btHexadecimal
            // 
            btHexadecimal.AutoSize = true;
            btHexadecimal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btHexadecimal.Location = new Point(688, 46);
            btHexadecimal.Name = "btHexadecimal";
            btHexadecimal.Size = new Size(138, 29);
            btHexadecimal.TabIndex = 7;
            btHexadecimal.TabStop = true;
            btHexadecimal.Text = "Hexadecimal";
            btHexadecimal.UseVisualStyleBackColor = true;
            btHexadecimal.CheckedChanged += btHexadecimal_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(620, 19);
            label2.Name = "label2";
            label2.Size = new Size(62, 24);
            label2.TabIndex = 2;
            label2.Text = "Base :";
            // 
            // StartAddressTextBox
            // 
            StartAddressTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            StartAddressTextBox.Location = new Point(872, 15);
            StartAddressTextBox.Name = "StartAddressTextBox";
            StartAddressTextBox.PlaceholderText = "Start Address";
            StartAddressTextBox.Size = new Size(155, 32);
            StartAddressTextBox.TabIndex = 8;
            StartAddressTextBox.TextChanged += StartAddressTextBox_TextChanged;
            StartAddressTextBox.KeyPress += StartAddressTextBox_KeyPress;
            // 
            // NoRegisterTextBox
            // 
            NoRegisterTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NoRegisterTextBox.Location = new Point(872, 53);
            NoRegisterTextBox.Name = "NoRegisterTextBox";
            NoRegisterTextBox.PlaceholderText = "Register Count";
            NoRegisterTextBox.Size = new Size(155, 32);
            NoRegisterTextBox.TabIndex = 9;
            NoRegisterTextBox.TextChanged += NoRegisterTextBox_TextChanged;
            NoRegisterTextBox.KeyPress += NoRegisterTextBox_KeyPress;
            // 
            // ReadModeComboBox
            // 
            ReadModeComboBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ReadModeComboBox.FormattingEnabled = true;
            ReadModeComboBox.Items.AddRange(new object[] { "ReadCoils - 0x01", "ReadDiscreteInputs - 0x02", "ReadHoldingRegisters - 0x03", "ReadInputRegisters - 0x04" });
            ReadModeComboBox.Location = new Point(680, 106);
            ReadModeComboBox.Name = "ReadModeComboBox";
            ReadModeComboBox.Size = new Size(260, 33);
            ReadModeComboBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(535, 110);
            label3.Name = "label3";
            label3.Size = new Size(150, 24);
            label3.TabIndex = 2;
            label3.Text = "Reading Mode : ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1065, 590);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ModbusExceptionTextBox);
            tabPage1.Controls.Add(btConnect);
            tabPage1.Controls.Add(ReadModeComboBox);
            tabPage1.Controls.Add(NoRegisterTextBox);
            tabPage1.Controls.Add(TextBoxIP);
            tabPage1.Controls.Add(StartAddressTextBox);
            tabPage1.Controls.Add(PortTextBox);
            tabPage1.Controls.Add(btHexadecimal);
            tabPage1.Controls.Add(btDisconnect);
            tabPage1.Controls.Add(btDecimal);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Status);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1057, 552);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Client Mode";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ModbusExceptionTextBox
            // 
            ModbusExceptionTextBox.Location = new Point(927, 466);
            ModbusExceptionTextBox.Name = "ModbusExceptionTextBox";
            ModbusExceptionTextBox.ReadOnly = true;
            ModbusExceptionTextBox.Size = new Size(100, 32);
            ModbusExceptionTextBox.TabIndex = 11;
            ModbusExceptionTextBox.TextChanged += ModbusExceptionTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(763, 470);
            label5.Name = "label5";
            label5.Size = new Size(158, 24);
            label5.TabIndex = 2;
            label5.Text = "Exception code : ";
            label5.Click += label5_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(MaxClientTextBox);
            tabPage2.Controls.Add(TimeoutTextBox);
            tabPage2.Controls.Add(StopServer);
            tabPage2.Controls.Add(StartServ);
            tabPage2.Controls.Add(IPtextBoxServ);
            tabPage2.Controls.Add(StatusServer);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1057, 552);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Server Mode";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MaxClientTextBox
            // 
            MaxClientTextBox.Location = new Point(46, 330);
            MaxClientTextBox.Name = "MaxClientTextBox";
            MaxClientTextBox.PlaceholderText = "Max Clients";
            MaxClientTextBox.Size = new Size(123, 32);
            MaxClientTextBox.TabIndex = 7;
            MaxClientTextBox.TextChanged += MaxClientTextBox_TextChanged;
            // 
            // TimeoutTextBox
            // 
            TimeoutTextBox.Location = new Point(46, 368);
            TimeoutTextBox.Name = "TimeoutTextBox";
            TimeoutTextBox.PlaceholderText = "Timeout (ms)";
            TimeoutTextBox.Size = new Size(121, 32);
            TimeoutTextBox.TabIndex = 7;
            // 
            // StopServer
            // 
            StopServer.Location = new Point(175, 453);
            StopServer.Name = "StopServer";
            StopServer.Size = new Size(102, 37);
            StopServer.TabIndex = 6;
            StopServer.Text = "Stop";
            StopServer.UseVisualStyleBackColor = true;
            StopServer.Click += StopServer_Click;
            // 
            // StartServ
            // 
            StartServ.Location = new Point(44, 453);
            StartServ.Name = "StartServ";
            StartServ.Size = new Size(102, 37);
            StartServ.TabIndex = 6;
            StartServ.Text = "Start";
            StartServ.UseVisualStyleBackColor = true;
            StartServ.Click += StartServ_Click;
            // 
            // IPtextBoxServ
            // 
            IPtextBoxServ.Location = new Point(46, 406);
            IPtextBoxServ.Name = "IPtextBoxServ";
            IPtextBoxServ.PlaceholderText = "IP";
            IPtextBoxServ.Size = new Size(121, 32);
            IPtextBoxServ.TabIndex = 5;
            IPtextBoxServ.TextChanged += textBox1_TextChanged;
            IPtextBoxServ.KeyPress += textBox1_KeyPress;
            // 
            // StatusServer
            // 
            StatusServer.AutoSize = true;
            StatusServer.Location = new Point(83, 23);
            StatusServer.Name = "StatusServer";
            StatusServer.Size = new Size(159, 25);
            StatusServer.TabIndex = 4;
            StatusServer.Text = "Server listening ...";
            StatusServer.Click += StatusServer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 24);
            label4.Name = "label4";
            label4.Size = new Size(70, 24);
            label4.TabIndex = 3;
            label4.Text = "Status :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1067, 588);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ModbusUtilities";
            Load += label;
            Validated += Form1_Validated;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TextBoxIP;
        private Button btConnect;
        private Label label1;
        private TextBox PortTextBox;
        public Label Status;
        public System.Windows.Forms.Timer StatusModbus;
        private Button btDisconnect;
        public System.Windows.Forms.Timer ReadModbus;
        private System.Windows.Forms.Timer timer1;
        private RadioButton btDecimal;
        private RadioButton btHexadecimal;
        private Label label2;
        private TextBox StartAddressTextBox;
        private TextBox NoRegisterTextBox;
        private ComboBox ReadModeComboBox;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label StatusServer;
        private Label label4;
        private Button StopServer;
        private Button StartServ;
        private TextBox MaxClientTextBox;
        private TextBox TimeoutTextBox;
        public TextBox IPtextBoxServ;
        public TextBox ModbusExceptionTextBox;
        private Label label5;
    }
}
