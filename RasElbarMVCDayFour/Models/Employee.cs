using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RasElbarMVCDayFour.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string Name { get; set; }

        public string Address { get; set; }

        public decimal Salary { get; set; }

        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}
