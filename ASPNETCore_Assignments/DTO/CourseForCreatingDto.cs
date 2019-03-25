using System.Collections.Generic;

namespace ASPNETCore_Assignments.DTO
{
	public class CourseForCreatingDto
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public int? TeacherId { get; set; }

		public ICollection<CourseAssignmentForCreatingDto> CourseAssignmets { get; set; }
	}
}
