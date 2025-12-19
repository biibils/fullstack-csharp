using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebAppMVC.Models
{
	public class Course
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Nama Kursus harus diisi")]
		[StringLength(100, ErrorMessage = "Nama tidak boleh lebih dari 100 karakter")]
		public required string Name { get; set; }

		// Many-to-many navigation to students taking this course
		public virtual ICollection<Student> Students { get; set; } = new List<Student>();

		// Computed participant count (not mapped to DB). If you prefer a persisted column,
		// keep an integer property and update it when students enroll/unenroll.
		[NotMapped]
		public int Participant => Students?.Count ?? 0;
	}
}