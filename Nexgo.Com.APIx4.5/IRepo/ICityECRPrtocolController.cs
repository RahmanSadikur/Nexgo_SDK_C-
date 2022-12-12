using Nexgo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexgo.Com.APIx4._5.IRepo
{
    public interface ICityECRPrtocolController
    {
         ECRRecieverModel RecieverModel {get;set;}
         string FinalhexString { get; set; }
         string dataString { get; set; }
         void OpenPort(string portName);
         void SendingAcknowledgeToPos();
         void SendingMessageToPos(string amount, string invoice);
    }
}
