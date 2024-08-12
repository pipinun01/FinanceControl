using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager: IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IUserRepository> _userRepository; 
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IExpenseRepository> _expenseRepository;
        private readonly Lazy<IIncomeRepository> _incomeRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _context = repositoryContext;
            _userRepository = new Lazy<IUserRepository>(() =>new UserRepository(repositoryContext));
            _categoryRepository = new Lazy<ICategoryRepository>(()=>new CategoryRepository(repositoryContext));
            _expenseRepository = new Lazy<IExpenseRepository>(() => new ExpenseRepository(repositoryContext));
            _incomeRepository = new Lazy<IIncomeRepository>(() => new IncomeRepository(repositoryContext));
        }

        public IUserRepository user => _userRepository.Value;
        public IExpenseRepository expense => _expenseRepository.Value;
        public IIncomeRepository income => _incomeRepository.Value;
        public ICategoryRepository category => _categoryRepository.Value;

        public void Save()=> _context.SaveChanges();
    }
}
