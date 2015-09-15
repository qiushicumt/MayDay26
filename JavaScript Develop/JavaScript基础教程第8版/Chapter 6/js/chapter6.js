// 6-2 脚本2
window.onload = function() {
	document.getElementById("months").selectedIndex = 0;
	document.getElementById("months").
}
/*
// 6-2 脚本1
window.onload = function() {
	document.getElementById("months").selectedIndex = 0;	// selectedIndex选中的选项的index
	document.getElementById("months").onchange = populateDays;
}
function populateDays() {
	var monthDays = new Array(31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31);
	var monthStr = this.options[this.selectedIndex].value;
	if(monthStr != "") {
		var theMonth = parseInt(monthStr);
		document.getElementById("days").options.length = 0;
		for(var i = 0; i < monthDays[theMonth]; i++) {
			document.getElementById("days").options[i] = new Option(i+1);
		}
	}

}

// 6-1 脚本
window.onload = initForm;
window.onunload = function() {}
function initForm() {
	document.getElementById("newLocation").selectedIndex = 0;
	document.getElementById("newLocation").onchange = jumpPage;
}
function jumpPage() {
	var newLoc = document.getElementById("newLocation");
	var newPage = newLoc.options[newLoc.selectedIndex].value;
	if(newPage != "") {
		window.location = newPage;
	}
}
*/