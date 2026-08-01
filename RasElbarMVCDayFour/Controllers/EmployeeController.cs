using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RasElbarMVCDayFour.Models;

namespace RasElbarMVCDayFour.Controllers
{
    public class EmployeeController : Controller
    {
        CompanyDbContext _context = new CompanyDbContext();

        public IActionResult GetAll()
        {
            var emps = _context.Employees
                .Include(e => e.Department).ToList();

            return View("GetAll",emps);
        }
        public IActionResult Add()
        {
            ViewData["Departments"] = _context.Departments.ToList();
            return View("Add");
        }

        public IActionResult SaveAdd(Employee empFromUser)
        {

            if (ModelState.IsValid) 
            { 
                if(empFromUser.DepartmentId == null)
                {
                    ViewData["Departments"] = _context.Departments.ToList();

                    return View("Add", empFromUser);
                    
                }

                _context.Employees.Add(empFromUser);
                _context.SaveChanges();

                return RedirectToAction("GetAll");


            }
            ViewData["Departments"] = _context.Departments.ToList();

            return View("Add");
            

        }
    }
}
