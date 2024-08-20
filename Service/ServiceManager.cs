using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager: IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IIncomeService> _incomeService;
        private readonly Lazy<IExpenseService> _expenseService;
        private readonly Lazy<ICategoryService> _categoryService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, loggerManager, mapper));
            _incomeService = new Lazy<IIncomeService>(() => new IncomeService(repositoryManager,loggerManager, mapper));
            _expenseService = new Lazy<IExpenseService>(() => new ExpenseService(repositoryManager, loggerManager, mapper));
            _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, loggerManager, mapper));
        }
        public IUserService UserService => _userService.Value;
        public IIncomeService IncomeService => _incomeService.Value;
        public IExpenseService ExpenseService => _expenseService.Value;
        public ICategoryService CategoryService => _categoryService.Value;
    }
}
