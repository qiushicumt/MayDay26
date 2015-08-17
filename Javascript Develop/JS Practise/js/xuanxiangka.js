// 1-1 选项卡脚本1
window.onload = function() {
	var inputAll = document.getElementsByTagName("input");
	// inputAll[0].onclick = function() {inputAll[0].style.background = "#ff8400";}
	
	for(var i = 0; i < inputAll.length; i++) {
		inputAll[i].onclick = function() {
			alert(i);
			inputAll[i].style.background = "#ff8400";
		}
	}
	
}

/*
window.onload = initAll;
function initAll() {
	var oInput = document.getElementsByTagName("input");
	var oDiv = document.getElementsByTagName("div");
	for(i = 0; i < oInput.length; i++) {
		oInput
	}
	
	oInput[2].onclick = function() {
		oInput[2].style.backgroundColor = "#ff8400";
		alert(oInput[1].value);
		alert(oInput.length);
	}
	// for(var i = 0; i < oInput.length; i++) {
	// 	oInput[i].onclick = function() {
	// 		alert(oInput[i].value);
	// 		alert(oInput[i].value);
	// 	}
	// }
}
*/