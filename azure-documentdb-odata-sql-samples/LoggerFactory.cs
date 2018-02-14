using Microsoft.Extensions.Logging;
using System;

namespace azure_documentdb_odata_sql_tests
{
    public class Logger : Microsoft.Extensions.Logging.ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
        }
    }
    public class LoggerFactory : Microsoft.Extensions.Logging.ILoggerFactory
    {
        public void AddProvider(ILoggerProvider provider)
        {
         
        }

        public Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName)
        {
            return new Logger();
        }

        public void Dispose()
        {
          
        }
    }
}
