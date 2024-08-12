using FluentModbus;
using System;
using System.Net;
using System.Linq;
using System.Net.NetworkInformation;
namespace Modbus_Utilities
{
    public partial class Form1 : Form
    {
        public string IP;
        public int Port;
        public bool State;
        public bool StateServer;
        public ModbusTcpClient client;
        public ModbusTcpServer server;
        public enum ModbusExceptionCode;

        public Form1()
        {
            InitializeComponent();
            client = new ModbusTcpClient();
            server = new ModbusTcpServer();
            StatusServer.Text = "Server Stopped";
            StatusModbus.Start();
            ReadModbus.Start();
            ReadModeComboBox.SelectedIndex = 0;
            PortTextBox.Text = "503";
            btDecimal.Checked = true;
            StateServer = false;
            byte[] buffer = new byte[256]; // Exemple d'initialisation avec 256 bytes
            IPtextBoxServ.Text = GetDefaultIPv4();


        }
        private void IpTextBox(object sender, EventArgs e)
        {
            IP = TextBoxIP.Text;
        }

        public void btConnection(object sender, EventArgs e)
        {
            try
            {
                client.Connect(new IPEndPoint(IPAddress.Parse(IP), Port));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Double check connection params (Is host up ?)");
            }

        }

        private void label(object sender, EventArgs e)
        {

        }


        public void timer1_Tick(object sender, EventArgs e)
        {
            bool StateClient = client.IsConnected;
            int numClient = server.ConnectionCount;
            //string Error = ModbusException.ExceptionCode;
            {
                if (StateServer == true)
                {

                    StatusServer.Text = $"Server listening ... {numClient} clients connected";
                    StatusServer.ForeColor = Color.Green;
                    // btConnect.Enabled = false;

                }
                else
                {
                    StatusServer.Text = "Server Down...";
                    StatusServer.ForeColor = Color.Red;
                    //btConnect.Enabled = false;
                }
                if (StateClient == true)
                {
                    Status.Text = "Connected";
                    Status.ForeColor = Color.Green;
                    btConnect.Enabled = false;
                }
                else
                {
                    Status.Text = "Not Connected";
                    Status.ForeColor = Color.Red;
                    btConnect.Enabled = true;
                }
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }

        private void PortTextBox_TextChanged(object sender, EventArgs e)
        {
            Port = int.Parse(PortTextBox.Text);
        }

        public void timer1_Tick_1(object sender, EventArgs e)
        {
            Span<byte> data;
            if (!client.IsConnected)
            {

            }
            else
            {
                if (ReadModeComboBox.SelectedIndex == 0)
                {
                    try
                    {
                        data = client.ReadCoils(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (ReadModeComboBox.SelectedIndex == 1)
                {
                    try
                    {
                        client.ReadDiscreteInputs(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (ReadModeComboBox.SelectedIndex == 2)
                {
                    try
                    {
                        // client.ReadHoldingRegisters(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception ex)
                    {

                    }
                }
                if (ReadModeComboBox.SelectedIndex == 3)
                {
                    try
                    {
                        //client.ReadInputRegisters(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btHexadecimal.Checked = !btDecimal.Checked;
        }



        private void btHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            btDecimal.Checked = !btHexadecimal.Checked;
        }

        public void NoRegisterTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void StartAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Validated(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void StartAddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NoRegisterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusServer_Click(object sender, EventArgs e)
        {

        }

        public void StartServ_Click(object sender, EventArgs e)
        {
            try
            {
                server.Start(new IPEndPoint(IPAddress.Parse(IPtextBoxServ.Text), 503));
                server.MaxConnections = int.Parse(MaxClientTextBox.Text);

                StateServer = true;
                StartServ.Enabled = false;
            }
            catch (Exception ServStartEx)
            {
                StateServer = false;
                StartServ.Enabled = true;
                MessageBox.Show("Could not start server (Something might be already running through this port ?)");
            }
        }

        private void StopServer_Click(object sender, EventArgs e)
        {
            server.Stop();
            StartServ.Enabled = true;
            StateServer = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MaxClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public string GetDefaultIPv4()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    var ipProps = nic.GetIPProperties();
                    var ipv4 = ipProps.UnicastAddresses
                        .FirstOrDefault(addr => addr.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                    if (ipv4 != null)
                    {
                        return ipv4.Address.ToString();
                    }
                }
            }
            return "";
        }

        private void ModbusExceptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
