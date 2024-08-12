using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IncomeRepository: RepositoryBase<Income>, IIncomeRepository
    {
        public IncomeRepository(RepositoryContext context): base(context)
        { }
    }
}
