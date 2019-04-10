using ASPNETCore_Assignments.Model;
using System.Collections.Generic;

namespace ASPNETCore_Assignments.ViewModel
{
  public class SelectTeacherToCourseViewModel
  {
    public int? TeacherId { get; set; }
    public IEnumerable<Teacher> Teachers { get; set; }
    
  }
}
