using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.DTO
{
  public class CourseForUpdatingDto
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    public string Description { get; set; }
    public int? TeacherId { get; set; }
  }
}
