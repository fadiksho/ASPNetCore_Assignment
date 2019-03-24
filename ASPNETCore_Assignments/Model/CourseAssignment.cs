namespace ASPNETCore_Assignments.Model
{
	public class CourseAssignment
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public bool IsDone { get; set; }

		public Course Course { get; set; }
	}
}
