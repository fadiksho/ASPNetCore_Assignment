using ASPNETCore_Assignments.Abstraction;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Extensions;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Reository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPNETCore_Assignments.Peristence
{
	public class InMemoryPersonRepository : IPersonRepository
	{
		List<Person> _people;

		public InMemoryPersonRepository()
		{
			_people = new List<Person>()
			{
				new Person() { Name = "Fadi", PhoneNumber = "003011122", City = "USA"},
				new Person() { Name = "Mati", PhoneNumber = "099112234", City = "UK" },
				new Person() { Name = "Koko", PhoneNumber = "099721234", City = "USA"},
				new Person() { Name = "Kiki", PhoneNumber = "087612342", City = "USA"},
				new Person() { Name = "dodo", PhoneNumber = "099721234", City = "USA"},
				new Person() { Name = "mimo", PhoneNumber = "087612342", City = "USA"},
			};
		}

		public void Add(PersonDto dto)
		{
			var person = new Person()
			{
				Name = dto.Name,
				City = dto.City,
				PhoneNumber = dto.PhoneNumber,
				Id = Guid.NewGuid()
			};

			_people.Add(person);
		}

		public void Remove(Guid id)
		{
			var person = this._people.Where(p => p.Id == id).FirstOrDefault();
			if (person != null)
			{
				this._people.Remove(person);
			}
		}

		public bool Save()
		{
			return true;
		}

		public PaggingResult<Person> People(PersonQuery personQuery)
		{
			IEnumerable<Person> query = _people;

			if (!string.IsNullOrWhiteSpace(personQuery.OrderByNameAndCity))
			{
				var caseCopmarison = personQuery.CaseSensitive ? StringComparison.CurrentCultureIgnoreCase : StringComparison.CurrentCulture;
				query = _people
					.Where(p => p.Name.StartsWith(personQuery.OrderByNameAndCity)
					|| p.City.StartsWith(personQuery.OrderByNameAndCity, caseCopmarison));
			}
			
			query = personQuery.Ascending ? query.OrderBy(p => p.Name).ThenBy(p => p.City) :
				query.OrderByDescending(p => p.Name).ThenBy(p => p.City);

			// befor apply the pagging store the items count
			var totalItems = _people.Count();
			
			var peopleAfterPagging = query.ApplayPaging(personQuery);

			var paggingResult = new PaggingResult<Person>
			{
				CurrentPage = personQuery.Page,
				PageSize = personQuery.PageSize,
				TotalItems = totalItems,
				TResult = peopleAfterPagging
			};

			return paggingResult;
		}
	}
}
