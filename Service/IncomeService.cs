using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class IncomeService: IIncomeService
    {
        private IRepositoryManager _repositoryManager;
        private ILoggerManager _loggerManager;

        public IncomeService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }

        public IEnumerable<IncomeDto> GetAllIncomes(bool trackChanges)
        {
            try
            {
                var incomes = _repositoryManager.income.GetAllIncomes(trackChanges);
                var incomeDto = incomes.Select(se=> new IncomeDto ( se.IncomeId , se.Amount, se.Date, se.Description ));
                return incomeDto;
            }
            catch (Exception ex) 
            {
                _loggerManager.LogError($"GetAllIncomes: _messages: {ex.Message}\n _stacktrace: {ex.StackTrace}");
                throw;
            }
        }
    }
}
