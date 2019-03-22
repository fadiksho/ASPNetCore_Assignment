using System.Collections.Generic;

namespace ASPNETCore_Assignments.Entity
{
	public class Student
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public IList<StudentCourse> StudentCourses { get; set; }
		public IList<StudentTeacher> StudentTeachers { get; set; }
	}
}
