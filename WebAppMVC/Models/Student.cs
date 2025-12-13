using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "nama harus diisi")]
        [StringLength(100, ErrorMessage = "Nama tidak boleh lebih dari 100 karakter.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "email harus diisi.")]
        [EmailAddress(ErrorMessage = "Format email tidak valid.")]
        public required string Email { get; set; }

        [Range(18, 60, ErrorMessage = "Usia harus antara 18 dan 60")]
        public int Age { get; set; }
    }
}