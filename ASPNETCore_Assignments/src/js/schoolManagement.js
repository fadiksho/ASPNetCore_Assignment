require("jquery-validation");
require("jquery-validation-unobtrusive");
require("jquery-ajax-unobtrusive");

$(document).on('click', '[data-dynamic-toggle]', function (e) {
	let targetTrigger = e.target.attributes["data-dynamic-target"].value;
	let classToBeToggled = e.target.attributes["data-dynamic-toggle"].value;
	let targetElement = $(`#${targetTrigger}`);
	
	targetElement.toggleClass(classToBeToggled);
});

closeAddNewDashboardDropdown = function () {
	$('#AddNewInDashboardId').removeClass('show');
};

loadFormValidation = function (selector) {
	let form = $(selector);
	console.log(form);
	form.removeData('validator');
	form.removeData('unobtrusiveValidation');
	$.validator.unobtrusive.parse(form);
}