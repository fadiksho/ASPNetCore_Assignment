using ASPNETCore_Assignments.DTO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.ViewModel
{
	public class AssignStudentToCourseViewModel
	{
		public int CourseId { get; set; }
		[Required]
		public List<AssignStudentToCourseDto> Students { get; set; }
	}
}
