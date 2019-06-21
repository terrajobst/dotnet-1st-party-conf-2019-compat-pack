using Microsoft.Win32;

using Newtonsoft.Json;

using System;
using System.IO;

namespace Fabrikam.Logging
{
    public class MyLogger
    {
        public static MyLogger Instance = new MyLogger();

        private readonly TextWriter _writer;
        
        private MyLogger()
        {
            _writer = new StreamWriter(GetLoggingPath())
            {
                AutoFlush = true
            };
        }

        public void Write(string message)
        {
            OnLoggged(message);
            _writer.Write(message);
        }

        public void WriteLine(string message)
        {
            OnLoggged(message);
            _writer.WriteLine(message);
        }

        public void WriteLine(object o)
        {
            var json = JsonConvert.SerializeObject(o);
            WriteLine(json);
        }

        private static string GetLoggingPath()
        {
            var loggingDirectory = GetLoggingDirectory();
            var path = Path.Combine(loggingDirectory, "log.txt");
            Directory.CreateDirectory(loggingDirectory);
            return path;
        }

        private static string GetLoggingDirectory()
        {
#if NET472
            using (var key = Registry.CurrentUser.OpenSubKey(@"Software\Fabrikam"))
            {
                if (key?.GetValue("LoggingDirectoryPath") is string configuredPath)
                    return configuredPath;
            }
#endif

            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appDataPath, "Fabrikam", "Logging");
        }

        private void OnLoggged(string message)
        {
            Logged?.Invoke(message);
        }

        public event Action<string> Logged;
    }
}
