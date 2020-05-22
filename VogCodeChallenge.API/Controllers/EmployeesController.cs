using ChrisDunlop_vog_backend_codechalleneg.Classes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/Employees
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            Employee employee = new Employee();            
            return employee.GetAll();
        }

        // GET api/Employees/Department/5
        [HttpGet("{departmentid}")]
        public string Get(int departmentId)
        {
            return "value";
        }

        // POST api/Employees
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Employees/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}