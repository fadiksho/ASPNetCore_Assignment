using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.DTO
{
	public class StudentForCreatingDto
	{
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
	}
}
