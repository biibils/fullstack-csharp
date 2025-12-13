using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class StudentController : Controller
    {
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
                // Untuk sementara, kita hanya menampilkan data yang diterima
                ViewBag.Message = "Data siswa berhasil disimpan!";
                return View("Details", student);
            }
            return View(student);
        }

        public IActionResult Details(Student student)
        {
            return View(student);
        }
    }
}