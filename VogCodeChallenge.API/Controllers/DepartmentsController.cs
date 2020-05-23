using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/Departments")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private List<Department> departments = new List<Department>();

        // GET: api/Departments
        [HttpGet]
        public IEnumerable<Department> GetAll()
        {
            departments.Add(new Department { ID = 1, Name = "Application Development", Address = "123 4th Street NW Calgary Alberta" });
            departments.Add(new Department { ID = 2, Name = "Management", Address = "456 7th Street NE Calgary Alberta" });
            departments.Add(new Department { ID = 3, Name = "HR", Address = "789 10th Street SW Calgary Alberta" });

            return departments;            
        }

        // GET api/Departments/5
        [HttpGet("{id}")]
        public IEnumerable<Department> Get(int id)
        {
            GetAll();
            return departments.Where(departments => departments.ID == id);
        }
    }
}
