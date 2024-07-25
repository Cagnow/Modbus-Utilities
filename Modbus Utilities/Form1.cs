using FluentModbus;
using System.Net;
namespace Modbus_Utilities
{
    public partial class Form1 : Form
    {
        public string IP;
        public int Port;
        public bool State;
        public ModbusTcpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new ModbusTcpClient();
            StatusModbus.Start();
            ReadModbus.Start();
            ReadModeComboBox.SelectedIndex = 0;
            PortTextBox.Text = "503";
            btDecimal.Checked = true;

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
            bool State = client.IsConnected;
            {
                if (State == true)
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
            if (!client.IsConnected)
            {

            }
            else
            {
                if (ReadModeComboBox.SelectedIndex == 0)
                {
                    try
                    {
                        client.ReadCoilsAsync(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception exx)
                    {

                    }
                }
                if (ReadModeComboBox.SelectedIndex == 1)
                {
                    try
                    {
                        client.ReadDiscreteInputs(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception exx)
                    {

                    }
                }
                if (ReadModeComboBox.SelectedIndex == 2)
                {
                    try
                    {
                       // client.ReadHoldingRegisters(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception exx)
                    {

                    }
                }
                if (ReadModeComboBox.SelectedIndex == 3)
                {
                    try
                    {
                        //client.ReadInputRegisters(0, int.Parse(StartAddressTextBox.Text), int.Parse(NoRegisterTextBox.Text));
                    }
                    catch (Exception exx)
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
    }
}
