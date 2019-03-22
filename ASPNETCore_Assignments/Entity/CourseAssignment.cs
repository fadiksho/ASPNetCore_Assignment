namespace ASPNETCore_Assignments.Entity
{
	public class CourseAssignment
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public bool IsDone { get; set; }

		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}
