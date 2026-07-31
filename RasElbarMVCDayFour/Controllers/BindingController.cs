using Microsoft.AspNetCore.Mvc;
using RasElbarMVCDayFour.Models;

namespace RasElbarMVCDayFour.Controllers
{
    public class BindingController : Controller
    {
        public IActionResult Test(int id , string name)
        {
            return Content($"Id {id} name {name}");
        }

        public IActionResult BindingClass(Department department)
        {
            return Content($"Name : {department.Name} Manger : {department.MangerName}");
        }
    }
}
