using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab5
{
    class FileLogger
    {
        private string path;
        public static FileLogger instance;

        public FileLogger(string path)
        {
            if (instance != null)
            {
                throw new Exception("Tried to create two FileLoggers");
            }
            this.path = path;
            instance = this;
        }
        
        public void Log(string type, string msg)
        {
            WriteLine($"[{DateTime.Now.ToString()}] ({type}): {msg}");
        }

        public void LogWarning(string msg)
        {
            Log("WARNING", msg);
        }

        public void LogError(string msg)
        {
            Log("ERROR", msg);
        }

        public void WriteLine(string msg)
        {
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(msg);
            }
        }
    }
}
