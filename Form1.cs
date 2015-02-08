using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsFuzzerCS
{
    public partial class Form1 : Form
    {
        SerialPort ComPort = new SerialPort();
        pduFuctions pdufunc = new pduFuctions();
        
        
        string FLASH1 = "10",//7 gsm encoding
               FLASH2 = "14",//8 bit encoding
               FLASH3 = "18",// 16 bit 
               SILENT = "C0",//
               VOICE_MAIL = "C8",//
               NORMAL = "08";//16 bit encoding


        public Form1()
        {
            InitializeComponent();
            
            var ports = SerialPort.GetPortNames();
            combo_serial_ports.DataSource = ports;
            combo_serial_ports.SelectedIndex = 0;

            combo_sms_type.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            if (!ComPort.IsOpen)
            {
                if (combo_serial_ports.SelectedIndex > -1)
                {
                    //MessageBox.Show(String.Format("You selected port '{0}'", cb_comports.SelectedItem));
                    Connect(combo_serial_ports.SelectedItem.ToString());
                    btnopen.Text = "Close";
                }
                else
                {
                    MessageBox.Show("Please select a port first");
                }
            }
            else if (ComPort.IsOpen)
            {
                btnopen.Text = "Open";
                CloseSerialPort();
            }
        }

        private void Connect(string portName)
        {

            if (!ComPort.IsOpen)
            {
                ComPort.BaudRate = 9600;
                ComPort.PortName = portName;
                ComPort.Open();
                //Continue here....
            }
        }

        private void CloseSerialPort()
        {
            //var ComPort = new SerialPort(portName);
            if (ComPort.IsOpen)
            {
                ComPort.Close();
                //Continue here....
            }
        }

        private void btnpdumode_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.Write("AT+CMGF=0\r");
            }
            else
            {
                MessageBox.Show("Please Open Port");
            }
        }

        private void btn2g_Click(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            string SMS_TYPE = "";
            switch (combo_sms_type.SelectedIndex)
            {
                case 0:
                    SMS_TYPE = NORMAL;
                    break;
                case 1:
                    SMS_TYPE = FLASH3;
                    break;
                case 2:
                    SMS_TYPE = SILENT;
                    break;
                case 3:
                    SMS_TYPE = VOICE_MAIL;
                    break;
            }

            string pdu_bytes = pduFuctions.createPduSms(text_target.Text.ToString(),
                                     text_sms.Text.ToString(),
                                     SMS_TYPE, checkBox_delreport.Checked);
            if (ComPort.IsOpen)
            {
                ComPort.Write("AT+CMGS=17\r");
                Thread.Sleep(400);
                ComPort.Write(pdu_bytes);
                Thread.Sleep(50);
                ComPort.Write(new byte[] { 0x1A }, 0, 1);
            }
            else { MessageBox.Show("Please Open Com Port"); }
        }



    }
}
