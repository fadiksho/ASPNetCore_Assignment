using ASPNETCore_Assignments.Abstraction;
using ASPNETCore_Assignments.DTO;
using ASPNETCore_Assignments.Model;

namespace ASPNETCore_Assignments.ViewModel
{
	public class PersonViewModel
	{
		public PaggingResult<Person> PersonPagingResult { get; set; }

		public PersonQuery Query { get; set; }

		public PersonDto PersonDto { get; set; }
	}
}
