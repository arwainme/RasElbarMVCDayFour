using Microsoft.AspNetCore.Mvc;
using RasElbarMVCDayFour.Models;

namespace RasElbarMVCDayFour.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyDbContext _context = new CompanyDbContext();

        public IActionResult GetAll()
        {
            var emps = _context.Employees.ToList();

            return View("GetAll",emps);
        }
        public IActionResult Add()
        {
            ViewData
            return View("Add");
        }

        public IActionResult SaveAdd(Employee empFromUser)
        {

            if (ModelState.IsValid) 
            { 
                _context.Employees.Add(empFromUser);
                _context.SaveChanges();

                return RedirectToAction("GetAll");


            }
         
            return View("Add");
            

        }
    }
}
