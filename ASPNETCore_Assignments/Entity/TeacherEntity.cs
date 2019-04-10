using System.Collections.Generic;

namespace ASPNETCore_Assignments.Entity
{
	public class TeacherEntity
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<CourseEntity> Courses { get; set; }
			= new List<CourseEntity>();
	}
}
