
using System;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace Nexgo.Com.APIx4._5
{
    public class Config
    {
        //Purchase Identifier 
        public string pruchaseIdentifier;
        //Currency Name Identifier 
        public string currencyName;
        //Currency Code Identifier 
        public string currencyCode;
        //Invoice Identifier 
        public string invoiceIdentifier;
        //Pos cash register configuration Identifier 
        public string regConfigIdentifier;
        //amount 
        public float amount;
        //invoice no
        public int invoice;
        //data into ascii format
        public string dataString;
        //command starter
        public string stx = "02";
        //00 = command; 01=ack ; 02=nak
        public string type = "00";
        //data string lenght
        public string len = "";
        //command end
        public string etx = "03";
        //check sum
        public string lrc = "";
        //only data feild converted to hex
        public string DataHexFormat = "";
        //ready data for sending on pos
        public string FinalhexString = "";
        public bool isError = false;
        public string errorMessage = "";
        private readonly SerialPort serial;
        public string receievedData = "";

        public Config(SerialPort serial) {
            this.serial = serial;
            //this.InitializeSerialPort();
            //OpenSerialPort();
        }
        private void InitializeSerialPort()
        {   //COM6 #Quectel USB NMEA Port
            string portName = "COM6";
            string[] comPorts = SerialPort.GetPortNames();
            if (comPorts.Any())
            {
                var pname = comPorts.FirstOrDefault(a => a.Contains("COM6"));
                if (!string.IsNullOrEmpty(pname))
                {
                    serial.PortName = pname;
                }
            }
            serial.PortName = portName; //Com Port Name                
            serial.BaudRate = 9600; //COM Port 
            serial.Handshake = System.IO.Ports.Handshake.None;
            serial.Parity = Parity.None;
            serial.DataBits = 8;
            serial.StopBits = StopBits.One;
            serial.ReadTimeout = 200;
            serial.WriteTimeout = 200;
        }
        private void OpenSerialPort()
        {
            this.serial.Open();

        }

        private void SendingDataToPos(string data)
        {
            if (!serial.IsOpen)
            {
                serial.Open();
            }
            serial.DiscardInBuffer();
            serial.DiscardOutBuffer();
            try
            {
                // serial.Write(data);
                isError = false;
                byte[] hexstring = Encoding.ASCII.GetBytes(data);
                serial.Write(hexstring, 0, hexstring.Length);

                //foreach (byte hexval in hexstring)
                //{
                //    byte[] _hexval = new byte[] { hexval };     // need to convert byte 
                //                                                // to byte[] to write
                //    serial.Write(_hexval, 0, 1);
                //    Thread.Sleep(1);
                //}



            }
            catch (Exception ex)
            {
                this.isError = true;
                this.errorMessage = "Failed to SEND\n" + data + "\n" + ex + "\n";

            }
        }
   
        public void ConvertStringIntoMesg(string dataString) {
            this.dataString = dataString;
            int count = this.dataString.Count() + 1;
            //calculate len into hex
            len = count.ToString("X4");
            //convert data string into hex
            this.DataHexFormat = StringToHex(this.dataString);
            //<stx><len><type> data string into hex<etx>
            var hexDataWithoutLrc = this.stx + this.len + this.type + this.DataHexFormat + this.etx;
            //calculate check sum
            this.lrc = CheckSumCalculate(hexDataWithoutLrc);
            //<stx><len><type> data string into hex<etx><lrc>
            this.FinalhexString = hexDataWithoutLrc + this.lrc;
            SendingDataToPos(this.FinalhexString);

        }
        public void SendMessageInit(string amount,string invoice)
        {
            //A00 means purchase and A01 means void
            pruchaseIdentifier = "A00";
            //B01 Identifier and 156 BDT currency code
            currencyCode = "B01156";
            //B00 Identifier and TK currency name
            currencyName = "B00TK";
            //Unique invoice Identifier
            invoiceIdentifier = "Y00";
            //U00cashier
            regConfigIdentifier = "U0001";
            //validation check
            if(!float.TryParse(amount,out this.amount))
            {
                isError = true;
                errorMessage = "Invalid maount";
            }
            if ( !Int32.TryParse(invoice, out this.invoice))
            {
                isError = true;
                errorMessage = "Invalid invoice no";
            }
            isError = false;
            //amount * 100 (two decimal place fraction converted to decimal)
            this.amount *= 100;
            amount = this.amount.ToString();
            //ex: A0020000|B00TK|B01156|Y0090|U0001
            this.dataString = this.pruchaseIdentifier+amount+"|"+ this.currencyName + "|" + this.currencyCode + "|"+ this.invoiceIdentifier + invoice + "|"+regConfigIdentifier;
            ConvertStringIntoMesg(this.dataString);
        }
        private string StringToHex(string text)
        {
             
            byte[] data=Encoding.ASCII.GetBytes(text);
            
             return BitConverter.ToString(data).Replace("-", "");

        }
        private string CheckSumCalculate(string d)
        {
            byte[] data = StringToByteArray(d);
                
            byte l = 0;
            for(int i =0 ; i < data.Length; i++)
            {
                l ^= data[i];
            }
          
            return l.ToString("X");
        }
        //hexformat string convert into byte array
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

    }
}
