using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IIncomeRepository
    {
        IEnumerable<Income> GetAllIncomes(bool trackChanges);
        Income GetIncome(int id, bool trackChanges);
    }
}
