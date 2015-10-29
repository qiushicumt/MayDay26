window.onload = function() {
	var oDiv = document.getElementById("divCheckBox");
	var oBtn = document.getElementsByTagName("input");
	var oInput = oDiv.getElementsByTagName("input");
	// 全选按钮的onclick事件
	oBtn[0].onclick = function() {
		for(var i = 0; i < oInput.length; i++) {
			oInput[i].checked = true;
		}
	}
	// 反选按钮的onclick事件
	oBtn[1].onclick = function() {
		for(var i = 0; i < oInput.length; i++) {
			if(oInput[i].checked == true) {
				oInput[i].checked = false;
			}
			else {
				oInput[i].checked = true;
			}
		}
	}
}

/*
window.onload = function() {
	var oDiv = document.getElementById("divCheckBox");
	var oBtn1 = document.getElementById("btn1");
	var oBtn2 = document.getElementById("btn2");
	var oInput = oDiv.getElementsByTagName("input");

	// 全选按钮的onclick事件
	oBtn1.onclick = function() {
		for(var i = 0; i < oInput.length; i++) {
			oInput[i].checked = true;
		}
	}

	// 反选按钮的onclick事件
	oBtn2.onclick = function() {
		for(var i = 0; i < oInput.length; i++) {
			if(oInput[i].checked == true) {
				oInput[i].checked = false;
			}
			else {
				oInput[i].checked = true;
			}
		}
	}
}
*/