using ASPNETCore_Assignments.DTO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.ViewModel
{
	public class ManageStudentInCourseViewModel
	{
		public int CourseId { get; set; }
		[Required]
		public List<ManageStudentInCourseDto> Students { get; set; }
	}
}
