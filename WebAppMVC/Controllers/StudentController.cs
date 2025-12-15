using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;
using WebAppMVC.ViewModels;
using WebAppMVC.Services;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        // Dependensi Injection melalui konstruktor
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index(string? search, int? minAge, int? maxAge)
        {
            var students = _studentService.GetAllStudents();

            if (!string.IsNullOrWhiteSpace(search))
            {
                students = students.Where(s => s.Name.Contains(search) || s.Email.Contains(search)).ToList();
            }
            if (minAge.HasValue)
            {
                students = students.Where(s => s.Age >= minAge.Value).ToList();
            }
            if (maxAge.HasValue)
            {
                students = students.Where(s => s.Age <= maxAge.Value).ToList();
            }

            var vm = new StudentFilterViewModel
            {
                Search = search,
                MinAge = minAge,
                MaxAge = maxAge,
                Students = students.Select(s => new StudentViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    Email = s.Email,
                    Age = s.Age
                }).ToList()
            };
            return View(vm);
        }
        
        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // Protects against CSRF attacks
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // Disini untuk menyimpan data student ke database
                // Misalnya: _context.Students.Add(student);
                _studentService.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Edit/{id}
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Delete/{id}
        public IActionResult Delete(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Student/Details/{id}
        public IActionResult Details(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}