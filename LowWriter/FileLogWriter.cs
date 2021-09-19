using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LowWriter
{
    class FileLogWriter : ILogWritter 
    {
        public string pathToLogFile; 
        FileStream file;
       
        DateTime dateTime;
        public FileLogWriter(string path) { pathToLogFile = path; }
       
        
        public void LogInfo(string message)
        {
            dateTime = DateTime.Now;
            file = new FileStream(pathToLogFile, FileMode.Append, FileAccess.Write);
            StreamWriter StreamWriter = new StreamWriter(file);
            StreamWriter.WriteLine(dateTime.ToString("yyyy-MM-ddTHH:mm:ss+ffff") + "\nLogInfo" + "\n" + message);
            StreamWriter.Close();
            
        }
        public void LogWarning(string message)
        {
            file = new FileStream(pathToLogFile, FileMode.Append, FileAccess.Write);
            StreamWriter StreamWriter = new StreamWriter(file);
            dateTime = DateTime.Now;
            StreamWriter.WriteLine(dateTime.ToString("yyyy-MM-ddTHH:mm:ss+ffff") + "\nLogWarning" + "\n" + message);
            StreamWriter.Close();
        }
        public void LogError(string message)
        {
            file = new FileStream(pathToLogFile, FileMode.Append, FileAccess.Write);
            StreamWriter StreamWriter = new StreamWriter(file);
            dateTime = DateTime.Now;
            StreamWriter.WriteLine(dateTime.ToString("yyyy-MM-ddTHH:mm:ss+ffff") + "\nLogError" + "\n" + message);
            StreamWriter.Close();
        }
    }
}
