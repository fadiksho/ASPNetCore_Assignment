using ASPNETCore_Assignments.Abstraction;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using System;
using System.Collections.Generic;

namespace ASPNETCore_Assignments.Reository
{
	public interface IPersonRepository
	{
		PaggingResult<Person> People(PersonQuery personQuery);

		void Add(PersonDto dto);

		void Remove(Guid id);

		bool Save();
	}
}
