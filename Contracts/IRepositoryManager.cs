using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository user { get; }
        IIncomeRepository income { get; }
        IExpenseRepository expense { get; }
        ICategoryRepository category { get; }
        void Save();
    }
}
