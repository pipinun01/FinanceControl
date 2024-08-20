using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class IncomeNotFoundException: NotFoundException
    {
        public IncomeNotFoundException(int id) : base($"This income with id: {id} does not exist int the database")
        { }
    }
}
