using System.ComponentModel.DataAnnotations;

namespace RasElbarMVCDayFour.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[Display(Name = "Marwan")]
        public string MangerName { get; set; }

        public List<Employee>? Employees { get; set; } = new List<Employee>();



    }
}
