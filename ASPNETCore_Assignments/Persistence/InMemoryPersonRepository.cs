using ASPNETCore_Assignments.Abstraction;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Extensions;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Reository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPNETCore_Assignments.Persistence
{
	public class InMemoryPersonRepository : IPersonRepository
	{
		List<Person> _people;

		public InMemoryPersonRepository()
		{
			_people = new List<Person>()
			{
				new Person() { Id = Guid.NewGuid(), Name = "Fadi", PhoneNumber = "003011122", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "Mati", PhoneNumber = "099112234", City = "UK" },
				new Person() { Id = Guid.NewGuid(), Name = "Koko", PhoneNumber = "099721234", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "Kiki", PhoneNumber = "087612342", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "dodo", PhoneNumber = "099721234", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "mimo", PhoneNumber = "087612342", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "Fadi", PhoneNumber = "003011122", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "Mati", PhoneNumber = "099112234", City = "UK" },
				new Person() { Id = Guid.NewGuid(), Name = "Koko", PhoneNumber = "099721234", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "Kiki", PhoneNumber = "087612342", City = "USA"},
				new Person() { Id = Guid.NewGuid(), Name = "dodo", PhoneNumber = "099721234", City = "SSA"},
				new Person() { Id = Guid.NewGuid(), Name = "mimo", PhoneNumber = "087612342", City = "SSA"},
				new Person() { Id = Guid.NewGuid(), Name = "Fadi", PhoneNumber = "003011122", City = "SSA"},
				new Person() { Id = Guid.NewGuid(), Name = "Mati", PhoneNumber = "099112234", City = "SK" },
				new Person() { Id = Guid.NewGuid(), Name = "Koko", PhoneNumber = "099721234", City = "SSA"},
				new Person() { Id = Guid.NewGuid(), Name = "Kiki", PhoneNumber = "087612342", City = "SSA"},
				new Person() { Id = Guid.NewGuid(), Name = "dodo", PhoneNumber = "099721234", City = "SSA"},
				new Person() { Id = Guid.NewGuid(), Name = "mimo", PhoneNumber = "087612342", City = "SSA"},
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
			var person = this.GetPerson(id);
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

			if (!string.IsNullOrWhiteSpace(personQuery.Filter))
			{
				var caseCopmarison = personQuery.CaseSensitive ? StringComparison.CurrentCulture : StringComparison.OrdinalIgnoreCase;
				query = _people
					.Where(p => p.Name.StartsWith(personQuery.Filter, caseCopmarison)
					|| p.City.StartsWith(personQuery.Filter, caseCopmarison));
			}

			query = personQuery.Descending ? query.OrderByDescending(p => p.Name).ThenBy(p => p.City) :
				 query.OrderBy(p => p.Name).ThenBy(p => p.City);

			// befor apply the pagging store the items count
			var totalItems = query.Count();

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

		public void Update(PersonDto dto, Guid id)
		{
			var person = this.GetPerson(id);
			if (person != null)
			{
				person.Name = dto.Name;
				person.City = dto.City;
				person.PhoneNumber = dto.PhoneNumber;
			}
		}

		public Person GetPerson(Guid id)
		{
			return this._people.Where(p => p.Id == id).FirstOrDefault();
		}
	}
}
