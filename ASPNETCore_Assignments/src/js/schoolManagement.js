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
    targetElement.empty();
    targetElement.css('display', 'block');
	});
});

hideAfterSuceess = function (selector) {
  $(selector).removeClass('show');
};

showAfterSuccess = function (selector) {
  $(selector).addClass('show');
};

clearAfterSuccess = function (selector) {
  $(selector).hide('slow', function () {
    $(selector).empty();
    $(selector).css('display', 'block');
	});
}

loadFormValidation = function (selector) {
	let form = $(selector);
	form.removeData('validator');
	form.removeData('unobtrusiveValidation');
	$.validator.unobtrusive.parse(form);
}