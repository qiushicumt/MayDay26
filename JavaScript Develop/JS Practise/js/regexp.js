/*
window.onload = function() {	
	var oForm = document.getElementById("myForm");
	var oEmail = oForm.getElementsByTagName("input")[0];
	oForm.onsubmit = function(){
		var strPattern = /^[a-z]|[0-9]\w*\@\w*(\.com|\.net|\.org|\.cn)$/;
		if(oEmail.value.search(strPattern) == -1) {
			alert("Error email!");
			return false;
		}
	}
}

window.onload = function(){
	var oText1 = document.getElementById("myText1");
	var oBtn = document.getElementById("btn");	
	var oText2 = document.getElementById("myText2");
	var strPattern = /中国|人民/g;
	oBtn.onclick = function() {
		oText2.value = oText1.value.replace(strPattern, '**');
		
	}
}

window.onload = function() {
	var oForm = document.getElementById("myForm");
	var oEmail = oForm.getElementsByTagName("input")[0];
	
	oForm.onsubmit = function() {		
		//	var emailPattern = /\b[a-z]|[0-9]\w*\@\b(.com)|(.cn)|(.net)|(.co)/i;
		var emailPattern = /\b[a~z]/;
		if(oEmail.value.search(emailPattern) == -1) {
			alert("Error Email!");
			return false;
		}			
	}
}
*/