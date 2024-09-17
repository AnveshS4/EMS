using EMS1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace EMS1.Controllers
{
    public class EmployeeController : Controller
    {
        //private readonly IEmployeeRepository _employeeRepository;

        private readonly AppDbContext _appDbContext;
        public EmployeeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Employees.Add(employee);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);

        }
      /*  public IActionResult Edit(int id)
        {
            var obj = _appDbContext.Employees.FirstOrDefault(x => x.ID == id);
            return View(obj);
        }*/
        
      // public IActionResult Index()
       // {
        //    var obj = _appDbContext.Employees.ToList();
         //   return View(obj);

       // }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Employees.Update(employee);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        /* public IActionResult Delete(int id)
        {
            var obj = _appDbContext.Employees.Where(x => x.ID == id).FirstOrDefault();
            _appDbContext.Employees.Remove(obj);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        } */


    }
}

