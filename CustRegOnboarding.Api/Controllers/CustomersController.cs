using Microsoft.AspNetCore.Mvc;
using CustRegOnboarding.Domain;
using CustRegOnboarding.Application;

namespace CustRegOnboarding.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomersController(CustomerService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Customer customer)
        {
            var result = await _service.CreateAsync(customer);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }
    }
}
