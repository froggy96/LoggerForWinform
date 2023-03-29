using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DailyFileLogger
{
    public static class DailyFileLoggerExtensions
    {

        public static ILoggingBuilder AddDailyFileLogger(this ILoggingBuilder builder, Action<DailyFileLoggerOptions> configure)
        {
            builder.Services.AddSingleton<ILoggerProvider, DailyFileLoggerProvider>();
            builder.Services.Configure<DailyFileLoggerOptions>(configure);
            return builder;
        }

    }
}
