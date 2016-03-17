using System.IO;

namespace SingletonPattern
{
    public class LogManager
    {
        private static LogManager _instance;
        private FileStream _fileStream;
        private StreamWriter _streamWriter;
 
 
        private LogManager()
        {
            _fileStream = File.OpenWrite(GetExectionFolder()  + "Application.log");
       
            _streamWriter = new StreamWriter(_fileStream);
            _streamWriter.AutoFlush = true;
        }

        private string GetExectionFolder()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        public void WriteLog(string message)
        {
            _streamWriter.WriteLine(message);

        }

        public static LogManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LogManager();
                    
                }
                return _instance;
            }
        }

  
    }
}
