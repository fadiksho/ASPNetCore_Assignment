using System.ComponentModel.DataAnnotations;

namespace ASPNETCore_Assignments.DTO
{
  public class StudentForUpdatingDto
  {
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
  }
}
