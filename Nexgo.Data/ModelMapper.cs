using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexgo.Helper;
namespace Nexgo.Data
{
   public class ModelMapper
    {
       public static ECRRecieverModel RecieverDataMap(string receievedData, ref  ECRRecieverModel recieverModel)
        {
            //ECRRecieverModel recieverModel = new ECRRecieverModel();
            try
            {
                
                string[] splitedData = receievedData.Split('|');
                 recieverModel.CurrencyName = CleanData(splitedData.FirstOrDefault(a => a.Contains("B00")), 3);
                recieverModel.MaskedCaditCardNo = CleanData(splitedData.FirstOrDefault(a => a.Contains("Q01")), 3);
                recieverModel.TransactionStatus = CleanData(splitedData.FirstOrDefault(a => a.Contains("F0")), 2) == "0" ? "Transaction failed" : "Transaction successful";  
                recieverModel.TraceNo = CleanData(splitedData.FirstOrDefault(a => a.Contains("Q00")), 3);
                recieverModel.InvoiceId = CleanData(splitedData.FirstOrDefault(a => a.Contains("Y00")), 3);
                recieverModel.ErrorMessage = CleanData(splitedData.FirstOrDefault(a => a.Contains("E00")), 3);
                recieverModel.TransectionDateTime = CleanData(splitedData.FirstOrDefault(a => a.Contains("Q02")), 3);
                recieverModel.TerminalId = CleanData(splitedData.FirstOrDefault(a => a.Contains("Q03")), 3);
                recieverModel.MerchantId = CleanData(splitedData.FirstOrDefault(a => a.Contains("Q06")), 3);
                recieverModel.IsError = false;
                var amountString = CleanData(splitedData.FirstOrDefault(a => a.Contains("A00")),3);
                float amount;
                if (float.TryParse(amountString, out amount)) recieverModel.Amount = amount / 100;

                recieverModel.FullString = "Purchase Amount:" + recieverModel.Amount + ", " +
                      "Invoice No:" + recieverModel.InvoiceId + ", " +
                      "Currency Name:" + recieverModel.CurrencyName + ", " +
                      "Card No: " + recieverModel.MaskedCaditCardNo + ", " +
                      "Status: " + recieverModel.TransactionStatus + ", " +
                      "Date: " + recieverModel.TransectionDateTime + ", ";
                return recieverModel;

            }
            catch (Exception e)
            {
                recieverModel.IsError = true;
                recieverModel.ErrorMessage = e.Message;
                return recieverModel;
            }
           
        }
        private static string CleanData(string rawString, int index)
        {
            if (String.IsNullOrWhiteSpace(rawString) || String.IsNullOrEmpty(rawString))
            {
                return "";
            }
            return rawString.Substring(index, rawString.Length-index); ;

        }
       
    }
}
