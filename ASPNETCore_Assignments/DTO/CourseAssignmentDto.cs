using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.DTO
{
	public class CourseAssignmentForCreatingDto
	{
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
		public int CourseId { get; set; }
	}
}
