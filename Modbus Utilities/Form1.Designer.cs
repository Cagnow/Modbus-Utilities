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
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabPage1.Controls.Add(btConnect);
            tabPage1.Controls.Add(ReadModeComboBox);
            tabPage1.Controls.Add(NoRegisterTextBox);
            tabPage1.Controls.Add(TextBoxIP);
            tabPage1.Controls.Add(StartAddressTextBox);
            tabPage1.Controls.Add(PortTextBox);
            tabPage1.Controls.Add(btHexadecimal);
            tabPage1.Controls.Add(btDisconnect);
            tabPage1.Controls.Add(btDecimal);
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1057, 552);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Server Mode";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 588);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "ModbusUtilities";
            Load += label;
            Validated += Form1_Validated;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}
