using System;

using SingleResponsibilityPrinciple.Contracts;
using System.IO;

namespace SingleResponsibilityPrinciple
{
    public class ConsoleLogger : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {

                logfile.WriteLine("<log><type>WARN</type><message>" + message + "</message></log> ", args);
            }
        }

        public void LogInfo(string message, params object[] args)
        {
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {

                logfile.WriteLine("<log><type>INFO</type><message>" + message + "</message></log> ", args);
            }
        }
    }
}
