using System.Collections.Generic;

namespace ASPNETCore_Assignments.Entity
{
	public class StudentEntity
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public IList<StudentCourseEntity> StudentCourses { get; set; }
			= new List<StudentCourseEntity>();
	}
}
