using System.Collections.Generic;

namespace ASPNETCore_Assignments.Entity
{
	public class CourseEntity
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }

		public int TeacherId { get; set; }
		public TeacherEntity Teacher { get; set; }

		public IList<CourseAssignmentEntity> CourseAssignments { get; set; }
			= new List<CourseAssignmentEntity>();
		public IList<StudentCourseEntity> StudentCourses { get; set; }
			= new List<StudentCourseEntity>();
	}
}
