using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore_Assignments.Abstraction
{
	public interface IPagingQuery
	{
		int Page { get; set; }
		int PageSize { get; set; }
	}
}
