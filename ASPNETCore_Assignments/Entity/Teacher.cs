using System.Collections.Generic;

namespace ASPNETCore_Assignments.Entity
{
	public class Teacher
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<Course> Courses { get; set; }
		public IList<StudentTeacher> StudentTeachers { get; set; }
	}
}
