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

		public DbSet<StudentEntity> Students { get; set; }
		public DbSet<TeacherEntity> Teachers { get; set; }
		public DbSet<CourseEntity> Courses { get; set; }
		public DbSet<CourseAssignmentEntity> CourseAssignments { get; set; }
		
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Configure optional relationship where each course has one teacher and each teacher has many courses
			modelBuilder.Entity<CourseEntity>()
						.HasOne<TeacherEntity>(c => c.Teacher)
						.WithMany(t => t.Courses)
						.HasForeignKey(c => c.TeacherId)
						.IsRequired(false);

			// Configure each CourseAssignment has one Course and each Course has many CourseAssignments
			modelBuilder.Entity<CourseAssignmentEntity>()
						.HasOne<CourseEntity>(ca => ca.Course)
						.WithMany(ca => ca.CourseAssignments)
						.HasForeignKey(ca => ca.CourseId);

			// Configure each student has many coures and each course has many students
			modelBuilder.Entity<StudentCourseEntity>().HasKey(sc => new { sc.StudentId, sc.CourseId });

			modelBuilder.Entity<StudentCourseEntity>()
						.HasOne<StudentEntity>(sc => sc.Student)
						.WithMany(s => s.StudentCourses)
						.HasForeignKey(sc => sc.StudentId);
			modelBuilder.Entity<StudentCourseEntity>()
						.HasOne<CourseEntity>(sc => sc.Course)
						.WithMany(s => s.StudentCourses)
						.HasForeignKey(sc => sc.CourseId);
		}
	}
}
