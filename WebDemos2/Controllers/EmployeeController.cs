using Microsoft.AspNetCore.Mvc;
using WebDemos2.Contracts;

namespace WebDemos2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {


        private IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _repository.Add(employee);

            return Ok();
        }
    }
}
