using ASPNETCore_Assignments.Abstraction;

namespace ASPNETCore_Assignments.Model
{
	public class PersonQuery : IPagingQuery
	{
		public int Page { get; set; } = 1;
		public int PageSize { get; set; } = 5;
		
		public string Filter { get; set; }
		public bool Descending { get; set; }
		public bool CaseSensitive { get; set; }
	}
}
