using Contracts;
using Service.Contracts;

namespace Service
{
    internal sealed class UserService :IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;
        
        public UserService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }
    }
}
