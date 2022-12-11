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
using Nexgo.Com.APIx4._5;
using Nexgo.Data;
using Nexgo.Helper;


namespace Nexgo.client
{
    public partial class Form1 : Form
    {
        private  CityECRProtocl config;
        SerialPort _serialPort;
        public string receievedData = "";
        public ECRRecieverModel recieverModel;

        // delegate is used to write to a UI control from a non-UI thread
        private delegate void SetTextDeleg(string text);
        public Form1()
        {
            InitializeComponent();
            this.recieverModel=new ECRRecieverModel();
            _serialPort = new SerialPort();
            string portName = "COM10";
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.RtsEnable = true;
            string[] comPorts = SerialPort.GetPortNames();
            if (comPorts.Any())
            {
                var pname = comPorts.FirstOrDefault(a => a.Contains("COM10"));
                if (!string.IsNullOrEmpty(pname))
                {
                    _serialPort.PortName = pname;
                }
            }
            _serialPort.PortName = portName; //Com Port Name                
            _serialPort.BaudRate = 115200; //COM Port 
            _serialPort.Handshake = System.IO.Ports.Handshake.None;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
            try
            {
                _serialPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.config = new CityECRProtocl(_serialPort,recieverModel);

        }
        ~Form1()
        {
            _serialPort.Close();
        }
        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            
           
            this.config.ConvertStringIntoMesg(dataFieldTextBox.Text.ToString());
            if (config.isError)
            {
                MessageBox.Show(config.errorMessage);
                return;
            }
            this.stxlbl.Text = config.stx;
            this.lenLbl.Text = config.len;
            this.typeLbl.Text = config.type;
            this.dataLbl.Text = config.DataHexFormat;
            this.etxLbl.Text = config.etx;
            this.lrcLbl.Text = config.lrc;
            outputTextBox.Text = config.FinalhexString;
        }



        private void ProcessBtn_Click(object sender, EventArgs e)
        {

            this.config.SendMessageInit(amountTextBox.Text.ToString(), invoiceTextBox.Text.ToString());
            if (config.isError)
            {
                MessageBox.Show(config.errorMessage);
                return;
            }
            this.stxlbl.Text = config.stx;
            this.lenLbl.Text = config.len;
            this.typeLbl.Text = config.type;
            this.dataLbl.Text = config.DataHexFormat;
            this.etxLbl.Text = config.etx;
            this.lrcLbl.Text = config.lrc;
            outputTextBox.Text = config.FinalhexString;
            dataStringrtxb.Text = config.dataString;
        }

       
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
           
            try
            {
                
                this.receievedData = _serialPort.ReadExisting();
                var byteformatedText = DataConvertor.StringToHex(this.receievedData);
                this.receievedData = byteformatedText.ToString();
                if (!receievedData.Equals("020001010301") && !String.IsNullOrWhiteSpace(receievedData))
                {

                    string s = receievedData.Substring(0, receievedData.IndexOf("41"));
                    receievedData = receievedData.Remove(0, s.Length);
                    this.receievedData = DataConvertor.HexToString(receievedData);
                   this.recieverModel= ModelMapper.RecieverDataMap( receievedData);
                   this.receievedData = "Purchase Amount:" + this.recieverModel.Amount+", "+
                       "Invoice No:" + this.recieverModel.InvoiceId + ", " +
                       "Currency Name:" + this.recieverModel.CurrencyName + ", " +
                       "Card No: "+this.recieverModel.MaskedCaditCardNo+", "+
                       "Status: " + this.recieverModel.TransactionStatus + ", " +
                       "Date: " + this.recieverModel.TransectionDateTime + ", " +
                  

                    this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { this.receievedData });
                }
               
                
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
            
            
        }

        private void si_DataReceived(string data)
        {
            
            try
            {
                recievedoutputrtxb.Text = receievedData.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            
            config.SendingDataToPos();
            
        }
    }
}
