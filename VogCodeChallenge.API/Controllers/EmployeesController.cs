using ChrisDunlop_vog_backend_codechalleneg.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Linq;
using VogCodeChallenge.API.Classes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/Employees")]
    [Route("api/Departments")]
    [ApiController]

    public class EmployeesController : ControllerBase
    {

        private List<Employee> employees = new List<Employee>();

        // GET: api/Employees
        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            employees.Add(new Employee {ID = 1,
                                        DepartmentID = 1, 
                                        Department = new Department { ID = 1, Name = "Application Development", Address = "123 4th Street NW Calgary Alberta" }, 
                                        FirstName = "Chris", 
                                        LastName = "Dunlop", 
                                        JobTitle = "Software Developer", 
                                        MailingAddress = "1234 4th Avenue NW Calgary Alberta T1Y 6R5" });

            employees.Add(new Employee {ID = 2, 
                                        DepartmentID = 1,
                                        Department = new Department { ID = 1, Name = "Application Development", Address = "123 4th Street NW Calgary Alberta" },
                                        FirstName = "Joe", 
                                        LastName = "Nagal", 
                                        JobTitle = "Software Developer", 
                                        MailingAddress = "2345 5th Street NE Calgary Alberta T1Y 6R5" });
            employees.Add(new Employee {ID = 3, 
                                        DepartmentID = 1,
                                        Department = new Department { ID = 1, Name = "Application Development", Address = "123 4th Street NW Calgary Alberta" },
                                        FirstName = "Vinh", 
                                        LastName = "Lou", 
                                        JobTitle = "Software Developer", 
                                        MailingAddress = "3456 6th Street SW Calgary Alberta T1Y 6R5" });

            employees.Add(new Employee {ID = 4, 
                                        DepartmentID = 2,
                                        Department = new Department { ID = 2, Name = "Management", Address = "456 7th Street NE Calgary Alberta" },
                                        FirstName = "Vince", 
                                        LastName = "O'Gorman", 
                                        JobTitle = "Development Supervisor", 
                                        MailingAddress = "1201 49th Street NE Calgary Alberta T1Y 6R5" });
            employees.Add(new Employee { ID = 5, DepartmentID = 3, FirstName = "Tracey", LastName = "Jarvis", JobTitle = "HR Manager", MailingAddress = "1301 69th Street SW Calgary Alberta T1Y 6R5" });

            return employees;
        }

        //GET api/Employees/1
        [HttpGet("{id}")]
        public IEnumerable<Employee> Get(int id)
        {
            GetAll();
            return employees.Where(Employee => Employee.ID == id);
        }


        // GET api/Employees/Department/1
        [Route("[action]/{id}")]
        [HttpGet]
        public IEnumerable<Employee> Department(int id)
        {
            GetAll();
            return employees.Where(Employee => Employee.DepartmentID == id);            
        }
    }

    
}

