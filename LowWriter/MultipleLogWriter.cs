using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowWriter
{
    class MultipleLogWriter : ILogWritter
    {
        public FileLogWriter FileLogWriter;
        public ConsoleLogWriter ConsoleLog;
        public MultipleLogWriter(FileLogWriter Filelog, ConsoleLogWriter consoleLog) { FileLogWriter = Filelog; ConsoleLog = consoleLog; }
        public void LogInfo(string message)
        {
            FileLogWriter.LogInfo(message);
            ConsoleLog.LogInfo(message);
        }
        public void LogWarning(string message)
        {
            FileLogWriter.LogWarning(message);
            ConsoleLog.LogWarning(message);
        }
        public void LogError(string message)
        {
            FileLogWriter.LogError(message);
            ConsoleLog.LogError(message);
        }
    }
}
