using ASPNETCore_Assignments.Abstraction;

namespace ASPNETCore_Assignments.Model
{
	public class PersonQuery : IPagingQuery
	{
		public int Page { get; set; } = 1;
		public int PageSize { get; set; } = 5;

		public string OrderByNameAndCity { get; set; }
		public bool Ascending { get; set; } = true;
		public bool CaseSensitive { get; set; }
	}
}
