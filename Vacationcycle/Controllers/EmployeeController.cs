using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vacationcycle.Data;
using Vacationcycle.Models;

namespace Vacationcycle.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Employee> objList = _db.Employee;
            return View(objList);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee obj)
        {
            _db.Employee.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
     [HttpGet]
        public IActionResult Details(int id)
        {
            var obj = _db.Employee.Find(id);

            return View(obj);
        }


        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Employee.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Employee obj)
        {
            _db.Employee.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Employee.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? Id)
        {
            var obj = _db.Employee.Find(Id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Employee.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
