using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IIncomeService IncomeService { get; }
        IExpenseService ExpenseService { get; }
        ICategoryService CategoryService { get; }
    }
}
