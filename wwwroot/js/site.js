function msg(type, text) {
	let title = "";
	switch (type) {
		case "error":
			title = 'خطا!';
			break;
		case "success":
			title = 'عملیات موفق!';
			break;
		default:
			title = '';
			break;
	}
	Swal.fire({
		icon: type,
		title: title,
		text: text,
		buttonsStyling: false,
		confirmButtonText: 'بستن',
		customClass: {
			confirmButton: "btn btn-light font-weight-bold"
		}
	}).then(function () {
		KTUtil.scrollTop();
	});
}
function error(text) {
	msg('error', text);
}
function success(text) {
	msg('success', text);
}