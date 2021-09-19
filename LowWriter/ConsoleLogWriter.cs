using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowWriter
{
    class ConsoleLogWriter : ILogWritter
    {
        DateTime dateTime;
        public void LogInfo(string message)
        {
            dateTime = DateTime.Now;
           
            Console.WriteLine(dateTime.ToString("yyyy-MM-ddTHH:mm:ss+ffff") + "\nLogInfo" + "\n" + message);

        }
        public void LogWarning(string message)
        {
          
            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("yyyy-MM-ddTHH:mm:ss+ffff") + "\nLogWarning" + "\n" + message);
        }
        public void LogError(string message)
        {
           
            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("yyyy-MM-ddTHH:mm:ss+ffff") + "\nLogError" + "\n" + message);
        }
    }
}
