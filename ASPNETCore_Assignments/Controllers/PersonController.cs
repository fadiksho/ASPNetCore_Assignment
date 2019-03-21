using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Reository;
using ASPNETCore_Assignments.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;

namespace ASPNETCore_Assignments.Controllers
{
	public class PersonController : Controller
	{
		private readonly IPersonRepository personRepo;

		public PersonController(IPersonRepository personRepo)
		{
			this.personRepo = personRepo;
		}

		public IActionResult Index(PersonQuery query)
		{
			var personViewModel = this.BuildViewModel(query);

			return View(personViewModel);
		}

		public IActionResult Filter(PersonQuery query)
		{
			var personViewModel = this.BuildViewModel(query);

			return PartialView("_personList", personViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddNew(PersonDto personDto)
		{
			Thread.Sleep(2000);
			var personViewModel = this.BuildViewModel(new PersonQuery());
			if (!ModelState.IsValid)
			{
				personViewModel.PersonDto = personDto;
				return BadRequest(ModelState.Values);
			}

			this.personRepo.Add(personDto);

			if (!this.personRepo.Save())
			{
				personViewModel.PersonDto = personDto;
				return BadRequest();
			}

			return PartialView("_personList", personViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(Guid id)
		{
			Thread.Sleep(2000);
			this.personRepo.Remove(id);

			if (!this.personRepo.Save())
				return BadRequest(new { success = false });

			return Ok(new { id, success = true });
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult UpdatePerson(PersonDto personDto, Guid id)
		{
			Thread.Sleep(2000);
			if (!ModelState.IsValid)
				return BadRequest(new { success = false });

			this.personRepo.Update(personDto, id);
			if (!this.personRepo.Save())
				return BadRequest(new { success = false });

			return Ok(new { id, success = true });
		}

		private PersonViewModel BuildViewModel(PersonQuery query)
		{
			var pagginResult = this.personRepo.People(query);

			var personViewModel = new PersonViewModel()
			{
				Query = query,
				PersonPagingResult = pagginResult
			};

			return personViewModel;
		}
	}
}
