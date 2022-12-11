using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nexgo.Data;
using Nexgo.Helper;
namespace Nexgo.Com.APIx4._5

{
    
    class CommunicationController
    {
        private readonly SerialPort serialPort;
        private string receievedData;
        public ECRRecieverModel recieverModel;
        public CommunicationController(ECRRecieverModel recieverModel
            ,string portName,
            int baudRate = 115200,
            Handshake handShake = System.IO.Ports.Handshake.None,
            Parity parity = Parity.None,
            int dataBits = 8, 
            StopBits stopBits = StopBits.One,
            int readTimeout = 200,
            int writeTimeout = 200)
        {
            this.recieverModel = recieverModel;
            this.serialPort = new SerialPort();
            this.OpenSerialPort(portName, baudRate, handShake, parity, dataBits, stopBits, readTimeout, writeTimeout);
            
        }
        private void OpenSerialPort(string portName,
            int baudRate = 115200,
            Handshake handShake = System.IO.Ports.Handshake.None,
            Parity parity = Parity.None,
            int dataBits = 8, 
            StopBits stopBits = StopBits.One,
            int readTimeout = 200,
            int writeTimeout = 200)
       {
           
           
           try
           {
               this.serialPort.PortName = portName;
               this.serialPort.BaudRate = baudRate;
               this.serialPort.Handshake = handShake;
               this.serialPort.Parity = parity;
               this.serialPort.DataBits = dataBits;
               this.serialPort.StopBits = stopBits;
               this.serialPort.ReadTimeout = readTimeout;
               this.serialPort.WriteTimeout = writeTimeout;
               this.serialPort.DataReceived += new SerialDataReceivedEventHandler(RecieveDataFromSerialPort);
               if (!this.serialPort.IsOpen)
               {
                   this.serialPort.Open();
               }

           }
           catch (Exception e)
           {
               this.recieverModel.IsError = true;
               this.recieverModel.ErrorMessage = e.StackTrace;
           }
       }
       ~CommunicationController()
       {
           this.CloseSerialPort();
       }
       private void RecieveDataFromSerialPort(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);

            try
            {

                var streamString = serialPort.ReadExisting();
                var byteformatedText = DataConvertor.StringToHex(streamString);
                streamString = byteformatedText.ToString();
                if (!streamString.Equals("020001010301")){
                    string s = receievedData.Substring(0, receievedData.IndexOf("41"));
                    receievedData = receievedData.Remove(0, s.Length);
                    this.receievedData = DataConvertor.HexToString(receievedData);
                    this.recieverModel = ModelMapper.RecieverDataMap(receievedData);
                    
                }
                
                

                

            }
            catch (Exception ex)
            {
                this.recieverModel.IsError = true;
                this.recieverModel.ErrorMessage = ex.StackTrace;
              
            }



        }
        private void CloseSerialPort()
        {
            try
            {
                if (this.serialPort.IsOpen)
                {
                    this.serialPort.Close();
                }
               
            }
            catch (Exception e)
            {
                this.recieverModel.IsError = true;
                this.recieverModel.ErrorMessage = e.StackTrace;
            }


        }
        public void SendDataToSerialPort(string data)
        {

            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();

                this.recieverModel.IsError = false;

                byte[] hexstring = DataConvertor.StringToByteArray(data);
                serialPort.Write(hexstring, 0, hexstring.Length);



            }
            catch (Exception ex)
            {
                this.recieverModel.IsError = true;
                this.recieverModel.ErrorMessage = ex.StackTrace;

            }
        }
    }
}
