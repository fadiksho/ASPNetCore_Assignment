using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.DTO
{
	public class AssignStudentToCourseDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsSelected { get; set; }
	}
}
