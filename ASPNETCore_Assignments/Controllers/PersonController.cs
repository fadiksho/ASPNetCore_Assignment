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
		private readonly IPersonRepository _personRepo;

		public PersonController(IPersonRepository personRepo)
		{
			this._personRepo = personRepo;
		}

		public IActionResult Index(PersonQuery query)
		{
			var personViewModel = this.BuildViewModel(query);

			return View(personViewModel);
		}

		public IActionResult Filter(PersonQuery query)
		{
			Thread.Sleep(2000);
			var personViewModel = this.BuildViewModel(query);

			return PartialView("_personList", personViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddNew(PersonDto personDto)
		{
			//Thread.Sleep(2000);
			var personViewModel = this.BuildViewModel(new PersonQuery());

			if (!ModelState.IsValid)
			{
				personViewModel.PersonDto = personDto;
				return View("Index", personViewModel);
			}

			this._personRepo.Add(personDto);

			return PartialView("_personList", personViewModel);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(Guid id)
		{
			this._personRepo.Remove(id);
			return NoContent();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public JsonResult UpdatePerson(PersonDto personDto, Guid id)
		{
			if (ModelState.IsValid)
			{
				this._personRepo.Update(personDto, id);
			}
			return new JsonResult(false);
		}

		private PersonViewModel BuildViewModel(PersonQuery query)
		{
			var pagginResult = this._personRepo.People(query);
			var personViewModel = new PersonViewModel()
			{
				Query = query,
				PersonPagingResult = pagginResult
			};

			return personViewModel;
		}
	}
}
