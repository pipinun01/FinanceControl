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
            try
            {
                var incomes = _service.IncomeService.GetAllIncomes(trackChanges: false);
                return Ok(incomes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
