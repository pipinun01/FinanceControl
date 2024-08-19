using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IIncomeService
    {
        IEnumerable<IncomeDto> GetAllIncomes(bool trackChanges);
    }
}
