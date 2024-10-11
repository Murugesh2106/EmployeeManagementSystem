using EmployeeAttendanceManagementSystem.Data;
using EmployeeAttendanceManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttendanceManagementSystem.Controllers
{
    public class AttendancesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AttendancesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var attendances = _context.Attendances.Include("Employees");
            return View(attendances);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            LoadEmployees();
            return View();
        }
        [NonAction]
        private void LoadEmployees()
        {
            var employees = _context.Employees.ToList();
            ViewBag.Employees = new SelectList(employees, "Id", "Name");
        }
        [HttpPost]
        public IActionResult Create(Attendance model)
        {
            if (ModelState.IsValid)
            {
                _context.Attendances.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        { 
            if(id != null)
            {
                NotFound();
            }
            LoadEmployees();
            var attendance = _context.Attendances.Find(id);
            return View(attendance);
        }

        [HttpPost]
        public IActionResult Edit(Attendance model)
        {
            ModelState.Remove("Employees");
            if (ModelState.IsValid)
            {
                _context.Attendances.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                NotFound();
            }
            LoadEmployees();
            var attendance = _context.Attendances.Find(id);
            return View(attendance);

        }
         [HttpPost, ActionName("Delete")]
         public IActionResult DeleteConfirmed(Attendance model)
         {
            _context.Attendances.Remove(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
         }
        

        
    }
}

