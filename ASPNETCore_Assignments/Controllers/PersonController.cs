using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;
using ASPNETCore_Assignments.Reository;
using ASPNETCore_Assignments.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;

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

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult AddNew(PersonDto personDto)
		{
			if (!ModelState.IsValid)
			{
				var personViewModel = this.BuildViewModel(new PersonQuery());
				personViewModel.PersonDto = personDto;
				return View("Index", personViewModel);
			}

			this._personRepo.Add(personDto);

			return RedirectToAction("Index");
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(Guid id)
		{
			this._personRepo.Remove(id);
			return RedirectToAction("Index");
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
