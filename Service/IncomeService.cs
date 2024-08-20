using AutoMapper;
using Contracts;
using Entities.Exceptions;
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
        private IMapper _mapper;

        public IncomeService(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public IEnumerable<IncomeDto> GetAllIncomes(bool trackChanges)
        {
            var incomes = _repositoryManager.income.GetAllIncomes(trackChanges);
            var incomeDto = _mapper.Map<IEnumerable<IncomeDto>>(incomes);
            return incomeDto;
           
        }

        public IncomeDto GetIncome(int IncomeId, bool trackChanges)
        {
            var income = _repositoryManager.income.GetIncome(IncomeId, trackChanges);
            if(income is null)
            {
                throw new IncomeNotFoundException(IncomeId);
            }
            var incomeDto = _mapper.Map<IncomeDto>(income);
            return incomeDto;
        }
    }
}
