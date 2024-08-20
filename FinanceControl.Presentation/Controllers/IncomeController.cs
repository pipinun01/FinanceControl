using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceControl.Presentation.Controllers
{
    [Route("api/incomes")]
    [ApiController]
    public class IncomeController: ControllerBase
    {
        private readonly IServiceManager _service;
        
        public IncomeController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetIncomes()
        {
            var incomes = _service.IncomeService.GetAllIncomes(trackChanges: false);
            return Ok(incomes);
           
        }

        [HttpGet("{id:int}")]
        public IActionResult GetIncome(int id)
        {
                var income = _service.IncomeService.GetIncome(id, false);
            return Ok(income);
        }
    }
}
