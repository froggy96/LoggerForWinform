using DailyFileLogger;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggerForWinform
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // create logger provider
            DailyFileLoggerOptions options = new DailyFileLoggerOptions();
            options.LogRootFolderPath = ConfigurationManager.AppSettings["LogRootFolder"];
            options.FileName = ConfigurationManager.AppSettings["LogFileNameFormat"];
            _loggerProvider = new DailyFileLoggerProvider(options);
        }

        private ILoggerProvider _loggerProvider;

        private void btnLogTest_Click(object sender, EventArgs e)
        {
            if (_loggerProvider != null)
            {
                var msg = "This is logger testing...";

                var logger = _loggerProvider.CreateLogger("F01FOR01100101");
                logger.LogInformation(msg);
                Console.WriteLine(msg);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var logger = _loggerProvider.CreateLogger("MTS_TEST");

            List<Task> tasks = new List<Task>();
            for(int i = 0; i < 10; i++)
            {
                var task_id = i;
                tasks.Add(Task.Factory.StartNew(() => { LoggingWorker(task_id, logger); }));
            }
            await Task.WhenAll(tasks.ToArray());

            MessageBox.Show("Done!");
        }

        private void LoggingWorker(int task_id, ILogger logger)
        {
            var rand = new Random();
            EventId eventId = new EventId(task_id, $"EQPID-{task_id}");

            for(int i = 0; i < 10 ; i++)
            {
                var msg = $"TASK-ID:{task_id}, ({i}/10), {DateTime.UtcNow:T}";
                logger.LogInformation(eventId, msg);

                //
                System.Threading.Thread.Sleep(rand.Next(100));
            }
        }
    }
}
