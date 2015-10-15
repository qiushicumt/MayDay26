//  6-9 脚本
window.onload = function () {
    var oForm = document.getElementById("myForm");
    oForm.onsubmit = validForm;
}
function validForm() {
    var allGood = true;
    var oForm = document.getElementById("myForm");
    var oTags = oForm.getElementsByTagName("*");
    for (var i = 0; i < oTags.length; i++) {
        if (!validTag(oTags[i])) {
            allGood = false;
        }
    }
    return allGood;
}
function validTag(theTag) {

}
/*
// 6-3 脚本
window.onload = initForm;
function initForm() {
	var oForm = document.getElementById("myForm");
	oForm.onsubmit = function() {
		var allGood = true;
		var allTags = document.getElementsByTagName("*");
		for(var i = 0; i < allTags.length; i++) {
			if(!validTag(allTags[i])) {
				allGood = false;
			}
		}
		return allGood;
		function validTag(thisTag) {
			var outClass = "";
			var allClasses = thisTag.className.split(" ");	
			for(var j = 0; j < allClasses.length; j++) {
				outClass += validBasedOnClass(allClasses[j]) + " ";
			}
			thisTag.className = outClass;
			// 在此处，if的判断条件中对class属性进行判断，包含invalid则返回索引值，不包含则返回-1
			if(outClass.indexOf("invalid") > -1) {		
				thisTag.focus();
				if(thisTag.nodeName == "INPUT") {
					thisTag.select();
				}
				return false;
			}
			return true;
			function validBasedOnClass(thisClass) {
				var classBack = "";
				switch(thisClass) {
					case "":
					case "invalid":
						break;
					case "reqd":
						if(allGood && thisTag.value === "") {
							classBack = "invalid";
						}
						classBack += thisClass;
						break;
					default:
						if(allGood && !corssCheck(thisTag, thisClass)) {
							classBack = "invalid";
						}
						classBack += thisClass;
				}
				return classBack;
			}
			function corssCheck(inTag, otherFieldID) {
				if(!document.getElementById(otherFieldID)) {
					return false;
				}
				return (inTag.value == document.getElementById(otherFieldID).value);
			}
		}
	}
}

// 6-2 脚本2
window.onload = function() {
	document.getElementById("months").selectedIndex = 0;
	// document.getElementById("months").onchange = function() { populateDays(); }
	document.getElementById("months").onchange = populateDays;
}
function populateDays() {
	var daysArray = new Array(31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31);
	var monthStr = this.options[this.selectedIndex].value;
	if(monthStr != "") {
		var theMonth = parseInt(monthStr);
		document.getElementById("days").options.length = 0;
		for(var i = 0; i < daysArray[theMonth]; i++) {
			document.getElementById("days").options[i] = new Option(i+1);
		}
	}
}

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