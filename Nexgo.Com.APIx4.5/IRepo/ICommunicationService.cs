using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexgo.Com.APIx4._5.IRepo
{
    interface ICommunicationService
    {
         void OpenSerialPort(
            string portName,
            int baudRate = 115200,
            Handshake handShake = System.IO.Ports.Handshake.None,
            Parity parity = Parity.None,
            int dataBits = 8,
            StopBits stopBits = StopBits.One,
            int readTimeout = 200,
            int writeTimeout = 200
            );
         void SendDataToSerialPort(string data);
    }
}
