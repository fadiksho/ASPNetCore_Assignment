using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.DTO
{
	public class CourseForCreatingDto
	{
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
		[MaxLength(250)]
		public string Description { get; set; }

		public int? TeacherId { get; set; }

		public ICollection<CourseAssignmentForCreatingDto> CourseAssignmets { get; set; }
			= new List<CourseAssignmentForCreatingDto>();
	}
}
