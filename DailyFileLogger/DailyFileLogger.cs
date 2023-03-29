using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace DailyFileLogger
{
    public class DailyFileLogger : ILogger
    {
        protected readonly DailyFileLoggerProvider _provider;
        protected readonly string _filename_prefix;

        public DailyFileLogger(DailyFileLoggerProvider provider, string filename_prefix)
        {
            _provider = provider;
            _filename_prefix = filename_prefix;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel != LogLevel.None;
        }


        private static object _lock = new object();

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if(!IsEnabled(logLevel))
            {
                return;
            }

            //
            var level = logLevel.ToString().ToUpper().Substring(0, 4);

            //---------------------------------------------0123 56 89 12 45 78 012
            //---------------------------------------------yyyy-MM-dd HH:mm:ss.fff
            var time_stamp_string = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var folder_year = time_stamp_string.Substring(0, 4);
            var folder_month = time_stamp_string.Substring(5, 2);
            var folder_date = time_stamp_string.Substring(8, 2);

            var daily_folder_path = $"{_provider.Options.LogRootFolderPath}/{folder_year}/{folder_month}/{folder_date}";
            Directory.CreateDirectory(daily_folder_path);

            var filename = $"{_filename_prefix}_"  + _provider.Options.FileName.Replace("{item_id}", eventId.Name).Replace("{date}", $"{folder_year}{folder_month}{folder_date}");
            var log_file_path = $"{daily_folder_path}/{filename}";

            var msg = $"{time_stamp_string}, {level}, {formatter(state, exception)}";
            
            lock( _lock )
            {
                using (var sw = new StreamWriter(log_file_path, true))
                {
                    sw.WriteLine(msg);
                }
            }
        }
    }
}
