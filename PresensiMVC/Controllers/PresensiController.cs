using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using PresensiMVC.Models;

namespace PresensiMVC.Controllers
{
    public class PresensiController : Controllers
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Presensi/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Presensi/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Presensi presensi)
        {
            if (ModelState.IsValid)
            {
                // Simpan data presensi ke database atau lakukan operasi lainnya
                ViewBag.Message = "Presensi berhasil disimpan!";
                return View("Success", presensi);
            }
            return View(presensi);
        }

        public IActionResult Details(int id)
        {
            return View(presensi);
        }
    }
}