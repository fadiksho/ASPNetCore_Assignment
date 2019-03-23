namespace ASPNETCore_Assignments.Entity
{
	public class CourseAssignmentEntity
	{
		public int Id { get; set; }

		public string Name { get; set; }
		public bool IsDone { get; set; }

		public int CourseId { get; set; }
		public CourseEntity Course { get; set; }
	}
}
