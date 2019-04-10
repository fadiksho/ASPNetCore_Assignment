using System.Collections.Generic;

namespace ASPNETCore_Assignments.Model
{
	public class Teacher
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<Course> Courses { get; set; }
			= new List<Course>();
	}
}
