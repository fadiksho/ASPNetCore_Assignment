using System.Collections.Generic;

namespace ASPNETCore_Assignments.Entity
{
	public class Course
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }

		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }

		public IList<CourseAssignment> CourseAssignments { get; set; }
			= new List<CourseAssignment>();
		public IList<StudentCourse> StudentCourses { get; set; }
			= new List<StudentCourse>();
	}
}
