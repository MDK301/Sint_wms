$('.dropdown-menu').on('click', function (event) {
    var target = $(event.target);
    if (!target.hasClass('dropdown-item') && !target.closest('.dropdown-item').length) {
        event.stopPropagation();
    }
});

$('table tr.dropdown-item').on('click', function (event) {
    var target = $(event.target);
    console.log(target);

    var dropdownToggle = target.closest('.dropdown').find('input.dropdown-toggle');
    var mainField = target.closest('tr').find('td.mainField');
    $(dropdownToggle).text(mainField.text())
    $(dropdownToggle).val(mainField.text())
});

function SearchStaff() {
    var staffName = $("#jsSelectedStaff").val();
    if (!staffName) {
        return;
    }
    console.log(staffName);
    var $staffCard = $("#jsStaffCard");

    var searchCardUrl = "https://localhost:7242/Warehouse/SearchStaff?name="

    $staffCard.load(searchCardUrl, {
        'name': staffName,
    });
}