using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LowWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogWriter logsa = new FileLogWriter(@"D:\hta.txt");
            
            ConsoleLogWriter conlog = new ConsoleLogWriter();

            MultipleLogWriter multipleLogWriter = new MultipleLogWriter(logsa, conlog);

            multipleLogWriter.LogInfo("Test");
            multipleLogWriter.LogError("Test");
            multipleLogWriter.LogWarning("Test");
        }

    }
}
