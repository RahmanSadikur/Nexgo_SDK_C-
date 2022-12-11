using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexgo.Data
{
    public class ECRRecieverModel
    {
        public float Amount { get; set; }
        public string InvoiceId { get; set; }
        public string CurrencyName { get; set; }
        public string TransactionStatus { get; set; }
        public string MaskedCaditCardNo { get; set; }
        public string TraceNo { get; set; }
        public string TransectionDateTime { get; set; }
        public string TerminalId { get; set; }
        public string MerchantId { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
    }
}
