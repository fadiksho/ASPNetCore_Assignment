using System.Collections.Generic;

namespace ASPNETCore_Assignments.Abstraction
{
	public class PaggingResult<T> : PaggingData
	{
		public IEnumerable<T> TResult { get; set; }
	}
}
