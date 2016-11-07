using System;
using System.IO;
using System.ServiceProcess;
using System.Threading;

namespace SR
{
    public partial class Service1 : ServiceBase
    {
        Logger _logger;
        public Service1()
        {
            InitializeComponent();
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
        }

        protected override void OnStart(string[] args)
        {
            _logger = new Logger();
            Thread loggerThread = new Thread(new ThreadStart(_logger.Start));
            loggerThread.Start();
        }

        protected override void OnStop()
        {
            _logger.Stop();
            Thread.Sleep(1000);
        }
    }

    class Logger
    {
        FileSystemWatcher watch;
        object obj = new object();
        bool _enabled = true;
        public Logger()
        {
            watch = new FileSystemWatcher("D:\\SR");
            watch.Deleted += WatchDeleted;
            watch.Created += WatchCreated;
            watch.Changed += WatchChanged;
            watch.Renamed += WatchRenamed;
        }

        public void Start()
        {
            watch.EnableRaisingEvents = true;
            while (_enabled)
            {
                Thread.Sleep(1000);
            }
        }
        public void Stop()
        {
            watch.EnableRaisingEvents = false;
            _enabled = false;
        }
        // переименование файлов
        private void WatchRenamed(object sender, RenamedEventArgs e)
        {
            string fileEvent = "переименован в " + e.FullPath;
            string filePath = e.OldFullPath;
            RecordEntry(fileEvent, filePath);
        }
        // изменение файлов
        private void WatchChanged(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "изменен";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);
        }
        // создание файлов
        private void WatchCreated(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "создан";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);
        }
        // удаление файлов
        private void WatchDeleted(object sender, FileSystemEventArgs e)
        {
            string fileEvent = "удален";
            string filePath = e.FullPath;
            RecordEntry(fileEvent, filePath);
        }

        private void RecordEntry(string fileEvent, string filePath)
        {
            lock (obj)
            {
                using (StreamWriter writer = new StreamWriter("D:\\SRlog.txt", true))
                {
                    writer.WriteLine(String.Format("{0} файл {1} был {2}",
                        DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), filePath, fileEvent));
                    writer.Flush();
                }
            }
        }
    }
}
