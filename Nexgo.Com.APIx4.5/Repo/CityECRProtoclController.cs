
using System;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using Nexgo.Data;
using Nexgo.Helper;
using Nexgo.Com.APIx4._5.IRepo;
namespace Nexgo.Com.APIx4._5.Repo
{
    public class CityECRProtoclController : ICityECRPrtocolController
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
        public string dataString{get;set;}
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
        public string FinalhexString { get; set; }

        public string receievedData = "";

        public ECRRecieverModel RecieverModel
        {
            get;
            set;
        }
        private ICommunicationService communicationService;

        public CityECRProtoclController(string portName) {
            RecieverModel = new ECRRecieverModel();
            communicationService = new CommunicationService(RecieverModel, portName);


        }
        public void OpenPort(string portName)
        {

            communicationService.OpenSerialPort(portName);
        }
        public void SendingAcknowledgeToPos()
        {

            communicationService.SendDataToSerialPort("020001010301");
        }
        public void SendingMessageToPos(string amount,string invoice)
        {
            try
            {
                this.RecieverModel.IsError = false;
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
                if (!float.TryParse(amount, out this.amount))
                {
                    this.RecieverModel.IsError = true;
                    this.RecieverModel.ErrorMessage = "Invalid maount";
                    LogHelper.Log(this.RecieverModel.ErrorMessage);
                    return;
                }
                if (!Int32.TryParse(invoice, out this.invoice))
                {
                    this.RecieverModel.IsError = true;
                    this.RecieverModel.ErrorMessage = "Invalid invoice no";
                    LogHelper.Log(this.RecieverModel.ErrorMessage);
                    return;
                }
                
                //amount * 100 (two decimal place fraction converted to decimal)
                this.amount *= 100;
                amount = this.amount.ToString();
                //ex: A0020000|B00TK|B01156|Y0090|U0001
                this.dataString = this.pruchaseIdentifier + amount + "|" + this.currencyName + "|" + this.currencyCode + "|" + this.invoiceIdentifier + invoice + "|" + regConfigIdentifier;

                int count = this.dataString.Count() + 1;
                //calculate len into hex
                len = count.ToString("X4");
                //convert data string into hex
                this.DataHexFormat = DataConvertor.StringToHex(this.dataString);
                //<stx><len><type> data string into hex<etx>
                var hexDataWithoutLrc = this.stx + this.len + this.type + this.DataHexFormat + this.etx;
                //calculate check sum
                this.lrc = CheckSumCalculate(hexDataWithoutLrc);
                //<stx><len><type> data string into hex<etx><lrc>
                this.FinalhexString = hexDataWithoutLrc + this.lrc;
                
                communicationService.SendDataToSerialPort(this.FinalhexString);
            }
            catch (Exception e)
            {
                this.RecieverModel.IsError = true;
                this.RecieverModel.ErrorMessage =e.Message;
                LogHelper.Log(e.Message);
            }
           

        }

        private string CheckSumCalculate(string d)
        {
            try
            {
                byte[] data = DataConvertor.StringToByteArray(d);

                byte l = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    l ^= data[i];
                }

                return l.ToString("X");
            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.Message);
                return string.Empty;
            }

        }
       
      

    }
}
