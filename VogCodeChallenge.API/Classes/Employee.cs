using System.Collections.Generic;

namespace ChrisDunlop_vog_backend_codechalleneg.Classes
{
    public class Employee
    {
        #region Properties

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string MailingAddress { get; set; }

        #endregion Properties

        public IEnumerable<Employee> GetAll()
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee { ID = 1, FirstName = "Chris", LastName = "Dunlop", JobTitle = "Software Developer", MailingAddress = "123 4th Street NW Calgary Alberta T1Y 6R5" };
            employees[1] = new Employee { ID = 2, FirstName = "Vince", LastName = "O'Gorman", JobTitle = "Development Supervisor", MailingAddress = "123 4th Street NW Calgary Alberta T1Y 6R5" };
            employees[2] = new Employee { ID = 3, FirstName = "Tracey", LastName = "Jarvis", JobTitle = "HR Manager", MailingAddress = "123 4th Street NW Calgary Alberta T1Y 6R5" };

            return employees;
        }

        public IList<Employee> ListAll()
        {
            return null;
        }
    }
}