using ASPNETCore_Assignments.DTO;
using System.Collections.Generic;

namespace ASPNETCore_Assignments.ViewModel
{
  public class TeacherCourseAssignmentViewModel
  {
    public int CourseId { get; set; }

    public IEnumerable<CourseAssignmentForCreatingDto> CourseAssignments { get; set; }
  }
}
