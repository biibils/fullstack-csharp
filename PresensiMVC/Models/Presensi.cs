using System.ComponentModel.DataAnnotations;

namespace PresensiMVC.Models
{
    public class Attend
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "nama harus diisi")]
        [StringLength(100, ErrorMessage = "Nama tidak boleh lebih dari 100 karakter.")]
        public required string Name { get; set; }
        
        [Required(ErrorMessage = "Tanggal harus diisi.")]
        [DataType(DataType.DateTime)]
        public required DateTime Date { get; set; }

        public required string Status { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }
    }
}