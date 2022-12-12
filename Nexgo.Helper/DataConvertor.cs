using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexgo.Helper
{
    public static class DataConvertor
    {
         static DataConvertor() { }
        //hexformat string convert into byte array
        public static byte[] StringToByteArray(string hex)
        {
            try
            {
                return Enumerable.Range(0, hex.Length)
                            .Where(x => x % 2 == 0)
                            .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                            .ToArray();
            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.StackTrace);
                return new byte[] { };
            }
           
        }
        //string convert into Hex
        public static string StringToHex(string text)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(text);

                return BitConverter.ToString(data).Replace("-", "");
            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.StackTrace);
                return string.Empty;
            }


        }
        //hex convert into string
        public static string HexToString(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) 
            {  
                    LogHelper.Log(ex.StackTrace);
                    return string.Empty;
            }

           
        }
    }
}
