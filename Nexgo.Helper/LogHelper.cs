using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Nexgo.Helper
{
    public static class LogHelper
    {
        private static StreamWriter swLog;
        private const string sLOG_FILE_PATH = "log.txt";

        static LogHelper()
        {
            LogHelper.OpenLogger();
        }

        public static void OpenLogger()
        {
            LogHelper.swLog = new StreamWriter(sLOG_FILE_PATH, false);
            LogHelper.swLog.AutoFlush = true;
        }

        public static void Log(string sLogLine)
        {
            LogHelper.swLog.WriteLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + "\t:" + "\t" + sLogLine);
            LogHelper.swLog.Flush();
        }

        public static void CloseLogger()
        {
            LogHelper.swLog.Flush();
            LogHelper.swLog.Close();
        }
    }
}
