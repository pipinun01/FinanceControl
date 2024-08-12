namespace Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogDebugging(string message);
        void LogError(string message);
    }
}
