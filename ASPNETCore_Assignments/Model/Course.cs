using System.Collections.Generic;

namespace ASPNETCore_Assignments.Model
{
	public class Course
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }

		public Teacher Teacher { get; set; }

		public List<CourseAssignment> CourseAssignments { get; set; }
			= new List<CourseAssignment>();
		public List<Student> Students { get; set; }
			= new List<Student>();
	}
}
