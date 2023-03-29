using Microsoft.Extensions.Logging;
using System.IO;

namespace DailyFileLogger
{
    public class DailyFileLoggerProvider : ILoggerProvider
    {
        public readonly DailyFileLoggerOptions Options;

        public DailyFileLoggerProvider(DailyFileLoggerOptions options)
        {
            Options = options;

            if(!Directory.Exists(Options.LogRootFolderPath))
            {
                Directory.CreateDirectory(Options.LogRootFolderPath);
            }
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DailyFileLogger(this, categoryName);
        }

        public void Dispose()
        {
            // nothing to do...    :)
        }
    }
}
