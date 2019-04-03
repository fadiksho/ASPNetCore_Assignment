require("jquery-validation");
require("jquery-validation-unobtrusive");
require("jquery-ajax-unobtrusive");

$(document).on('click', '[data-dynamic-toggle]', function (e) {
	let targetTrigger = e.target.attributes["data-dynamic-target"].value;
	let classToBeToggled = e.target.attributes["data-dynamic-toggle"].value;
	let targetElement = $(`#${targetTrigger}`);
	
	targetElement.toggleClass(classToBeToggled);
});

$(document).on('click', '[data-dynamic-toggle-remove]', function (e) {
	let targetTrigger = e.target.attributes["data-dynamic-toggle-remove"].value;
	let targetElement = $(`#${targetTrigger}`);
	targetElement.hide('slow', function () {
		targetElement.remove();
	});
});

closeAddNewDashboardDropdown = function () {
	$('#AddNewInDashboardId').removeClass('show');
};

removeAfterSuccess = function (selector) {
	$(selector).hide('slow', function () {
		$(selector).remove();
	});
}

loadFormValidation = function (selector) {
	let form = $(selector);
	form.removeData('validator');
	form.removeData('unobtrusiveValidation');
	$.validator.unobtrusive.parse(form);
}