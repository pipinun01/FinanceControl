using Contracts;
using NLog;

namespace LoggerService
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public LoggerManager() { }

        public void LogDebugging(string msg)=>logger.Debug(msg);
        public void LogError(string msg)=>logger.Error(msg);
        public void LogInfo (string msg)=>logger.Info(msg);
        public void LogWarning(string msg)=>logger.Warn(msg);
    }
}

//Методы из интерфейса ILoggerManager:
//void LogInfo(string message);
//void LogWarning(string message);
//void LogDebugging(string message);
//void LogError(string message);