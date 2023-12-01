using System.IO;

namespace Days6
{
    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }
        public void logError(string msg)
        {
            log(msg, " ERROR ");
           
           // var stream=new StreamWriter(path,true);
           
        }

        public void logInfo(string msg)
        {
            log(msg, " INFO ");
        }
        private void log(string msg, string msgType)
        {
            using (var stream = new StreamWriter(path, true))
            {
                stream.WriteLine(msgType+" : " + msg);
            }
        }
    }
    }

