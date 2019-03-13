using ASPNETCore_Assignments.Abstraction;
using System.Collections.Generic;
using System.Linq;

namespace ASPNETCore_Assignments.Extensions
{
	public static class IEnumerableExtensions
	{
		public static IEnumerable<T> ApplayPaging<T>(this IEnumerable<T> query, IPagingQuery pagingParameter)
		{
			return query
				.Skip(pagingParameter.PageSize * (pagingParameter.Page - 1))
				.Take(pagingParameter.PageSize)
				.AsEnumerable();
		}
	}
}
