using Microsoft.EntityFrameworkCore;
using WebAppMVC.Models;

namespace WebAppMVC.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
		}

		public DbSet<Student> Students { get; set; }

		public DbSet<Course> Courses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Student>().ToTable("Students");
			modelBuilder.Entity<Course>().ToTable("Courses");

			// Configure many-to-many join table name
			modelBuilder.Entity<Course>()
				.HasMany(c => c.Students)
				.WithMany(s => s.Courses)
				.UsingEntity(j => j.ToTable("CourseStudents"));
		}
 	}
}