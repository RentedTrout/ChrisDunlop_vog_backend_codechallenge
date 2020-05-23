using System.ComponentModel.DataAnnotations.Schema;
using VogCodeChallenge.API.Classes;
namespace ChrisDunlop_vog_backend_codechalleneg.Classes
{
    public class Employee
    {
        #region Properties

        public int ID { get; set; }

        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }

        public int DepartmentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string MailingAddress { get; set; }

        #endregion Properties
    }
}