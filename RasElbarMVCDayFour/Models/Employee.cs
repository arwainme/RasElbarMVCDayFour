using RasElbarMVCDayFour.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RasElbarMVCDayFour.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")] ////1
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(10, ErrorMessage = "Name cannot exceed 10 characters")] /////1
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long")]
        [RegularExpression(@"^[A-Z][a-zA-Z]*$")]
        public string Name { get; set; }

        [RegularExpression(@"(Cairo|Alexandria|Giza|Damietta)")]

        public string Address { get; set; } //1 

        [Required]
        [Salary]

        public decimal Salary { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}
