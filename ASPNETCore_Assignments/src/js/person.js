require("jquery-validation");
require("jquery-validation-unobtrusive");
require("jquery-ajax-unobtrusive");

let addNewPersonForm = $("#addNewPersonFormId");
let filterPersonListFormId = $("#filterPersonListFormId");
let personEditForm = $("#personEditFormId");
let person, seletedPersonTile;

// delegate the event to capture new elements from ajax calls
$(document).on('click', '#cancelEditButtonId', function (e) {
	toggleEditFormVisibility(false);
	seletedPersonTile.show('slow');
});

$(document).on('click', '[edit-person]', function (e) {
	if (seletedPersonTile) {
		seletedPersonTile.show('slow');
	}
	let personTileId = e.target.attributes["edit-person"].value;
	seletedPersonTile = $(`#${personTileId}`);
	seletedPersonTile.hide('slow');
	seletedPersonTile.before(personEditForm);
	toggleEditFormVisibility(true);
	person = getJsonDataFromPersonTile();
	populatePersonFormWithJsonData(personEditForm, person);
});

function toggleEditFormVisibility(isVisable) {
	if (isVisable) {
		personEditForm.show('slow');
	} else {
		personEditForm.hide('slow');
	}
}
function getJsonDataFromPersonTile() {
	let personProperties = seletedPersonTile.find('[bindable-property]');
	person = {};
	personProperties.each(function (index) {
		let value = $.trim($(this).text()) || $(this).val();
		person[$(this).attr('name')] = value;
	});
	return person;
}
function getJsonPersonFromEditForm() {
	let serializeArrayData = personEditForm.serializeArray();
	let updatedPerson = {};

	$.map(serializeArrayData, function (n, i) {
		let nameExpression = n['name'].split('.');
		let name = nameExpression[nameExpression.length - 1];
		name = name.substr(0, 1).toLowerCase() + name.substr(1)
		updatedPerson[name] = n['value'];
	});
	// set the id from the selected person
	updatedPerson.id = person.id;
	return updatedPerson;
}
function populatePersonFormWithJsonData(form, formData) {
	$.each(formData, function (key, value) {
		$('[name="PersonDto.' + key.substr(0, 1).toUpperCase() + key.substr(1) + '"]:not([type=hidden])', form).val(value);
	});
	// set the id
	$('[name=id]', form).val(formData.id);
	form.find('input').first().focus();
}
function populatePersonTileWithJsonData(data) {
	$.each(data, function (key, value) {
		let personField = $('[name=' + key + ']', seletedPersonTile);
		personField.text(value);
	});
}

addPersonSuccess = function (response) {
	addNewPersonForm.find("input[type=text]").val("");
	// Todo: Add toast
	console.log(response);
};
addPersonFailure = function (response) {
	// Todo: Add toast
	console.log(response);
}

updatePersonSuccess = function (response) {
	toggleEditFormVisibility(false);
	let updatedPerson = getJsonPersonFromEditForm();
	populatePersonTileWithJsonData(updatedPerson);
	seletedPersonTile.show('slow');
	// Todo: Add toast
	console.log(response);
};

updatePersonFailure = function (response) {
	// Todo: Add toast
	console.log(response);
};

deletePersonSuccess = function (response) {
	if (response.success === true) {
		$(`#person_row_${response.id}`).hide('slow');
		// Todo: Add toast
		console.log(response);
	}
};
deletePersonFailure = function (response) {
	// Todo: Add toast
	console.log(response);
};
