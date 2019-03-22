using ASPNETCore_Assignments.Entity;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore_Assignments.Persistence.Data
{
	public class SchoolManagementContext : DbContext
	{
		public SchoolManagementContext(DbContextOptions<SchoolManagementContext> options)
			: base(options)
		{

		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseAssignment> CourseAssignments { get; set; }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Configure each course has one teacher and each teacher has many courses
			modelBuilder.Entity<Course>()
						.HasOne<Teacher>(c => c.Teacher)
						.WithMany(t => t.Courses)
						.HasForeignKey(c => c.TeacherId);

			// Configure each CourseAssignment has one Course and each Course has many CourseAssignments
			modelBuilder.Entity<CourseAssignment>()
						.HasOne<Course>(ca => ca.Course)
						.WithMany(ca => ca.CourseAssignments)
						.HasForeignKey(ca => ca.CourseId);

			// Configure each student has many coures and each course has many students
			modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });

			modelBuilder.Entity<StudentCourse>()
						.HasOne<Student>(sc => sc.Student)
						.WithMany(s => s.StudentCourses)
						.HasForeignKey(sc => sc.StudentId);
			modelBuilder.Entity<StudentCourse>()
						.HasOne<Course>(sc => sc.Course)
						.WithMany(s => s.StudentCourses)
						.HasForeignKey(sc => sc.CourseId);
		}
	}
}
