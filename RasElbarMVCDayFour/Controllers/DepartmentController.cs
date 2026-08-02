using Microsoft.AspNetCore.Mvc;
using RasElbarMVCDayFour.Models;

namespace RasElbarMVCDayFour.Controllers
{
    public class DepartmentController : Controller
    {
        CompanyDbContext _Context = new CompanyDbContext();

        [HttpGet]
        public IActionResult Index()
        {
            var depts = _Context.Departments.ToList();

            return View("Index" ,depts);
            
        }

        public IActionResult Add()
        {
            return View("Add");  
        }


        [HttpPost]

        // ModelState.IsValid => check if all the validation attributes are valid or not


        public IActionResult SaveAdd(Department deptfromUser)
        {
            if (deptfromUser.Name == null || deptfromUser.MangerName == null)
            {
                return View("Add",deptfromUser);
            }
            Department deptToDB = new Department();
            deptToDB.Name = deptfromUser.Name;
            deptToDB.MangerName = deptfromUser.MangerName;
            _Context.Departments.Add(deptToDB);

            _Context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {
            var dept = _Context.Departments.FirstOrDefault(x=> x.Id == id);

            return View("Edit" , dept);
        }

        public IActionResult SaveEdit(Department deptFromUser , int id)
        {
            var deptFromDB =
                _Context.Departments.FirstOrDefault(x => x.Id == id);
            deptFromDB.Name = deptFromUser.Name;
            deptFromDB.MangerName = deptFromUser.MangerName;

            _Context.SaveChanges();

            return RedirectToAction("Index");


        }
    }
}
