using System;
using System.IO;

namespace Interface
{
    interface Ilogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : Ilogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : Ilogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;

        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private Ilogger logger;
        public ClimateMonitor(Ilogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while( true )
            {
                Console.Write("온도를 입력해주세요.: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                logger.WriteLog("현재 온도 : " + temperature);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(
                new FileLogger("MyLog.txt"));

            monitor.start();
        }
    }
}
