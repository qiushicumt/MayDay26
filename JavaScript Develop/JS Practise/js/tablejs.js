// table 脚本4
window.onload = function() {
	var oDiv = document.getElementById("inputDIV");
	var oInput = oDiv.getElementsByTagName("input");
	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;
	var id = oRow.length;

	oInput[2].onclick = function() {
		var oTr = document.createElement("tr");

		var oTd = document.createElement("td");
		// 通过使用全局变量id来保存id的值，可以使id不会随着表格行的删除而减小
		oTd.innerHTML = ++id;
		oTr.appendChild(oTd);

		var oTd = document.createElement("td");
		oTd.innerHTML = oInput[0].value;
		oTr.appendChild(oTd);

		var oTd = document.createElement("td");
		oTd.innerHTML = oInput[1].value;
		oTr.appendChild(oTd);

		var oTd = document.createElement("td");
		oTd.innerHTML = "<a href=\"javascript:;\">删除</a>";
		oTr.appendChild(oTd);

		// 直接寻找最后一个td的子元素就是a，通过removeChild()方法删除子节点
		oTd.getElementsByTagName("A")[0].onclick = function() {
			oTab.tBodies[0].removeChild(this.parentNode.parentNode);
		}

		oTab.tBodies[0].appendChild(oTr);
	}
	// for(var i = 0; i < oRow.length; i++) {
	// 	var oLink = oRow[i].cells[3];
	// 	oLink.onclick = function() {
	// 		//this.parentNode.parentNode.parentNode.removeChild("tr");
	// 		oTab.removeChild(this.parentNode.parentNode);
	// 	}
	// }
}

/*
// table 脚本3
window.onload = function() {
	createRows();
	rowsColorChange();
}
function createRows() {
	var oDiv = document.getElementById("inputDIV");
	var oInput = oDiv.getElementsByTagName("input");
	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;
	oInput[2].onclick = function() {
		var oTr = document.createElement("tr");

		var oTd = document.createElement("td");
		oTd.innerHTML = oRow.length + 1;
		oTr.appendChild(oTd);

		var oTd = document.createElement("td");
		oTd.innerHTML = oInput[0].value;
		oTr.appendChild(oTd);

		var oTd = document.createElement("td");
		oTd.innerHTML = oInput[1].value;
		oTr.appendChild(oTd);

		oTab.tBodies[0].appendChild(oTr);
	}
}
function rowsColorChange() {
	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;
	var oldColor;
	for(var i = 0; i < oRow.length; i++) {
		if(i%2) {
			oRow[i].style.background = "#ccc";
		}
		else {
			oRow[i].style.background = "";
		}
		oRow[i].onmouseover = function() {
			oldColor = this.style.background;
			this.style.background = "rgb(134,219,34)";
		}
		oRow[i].onmouseout = function() {
			this.style.background = oldColor;
		}
	}
}

// table 脚本2
window.onload = function() {
	rowsColorChange();
	createRows();
}
function rowsColorChange() {
	oDiv = document.getElementById("wrappage");
	oTab = document.getElementById("myTable");
	oRow = oTab.tBodies[0].rows;
	var oldColor; 

	for(var i = 0; i < oRow.length; i++) {
		if(i%2) {
			oRow[i].style.background = "#CCC";
		}
		else {
			oRow[i].style.background = "";
		}
		oRow[i].onmouseover = function() {
			oldColor = this.style.background;
			this.style.background = "green";
		}
		oRow[i].onmouseout = function() {
			this.style.background = oldColor;
		}
	}
}
function createRows() {
	var oDiv = document.getElementById("addInfo");
	var oNameText = document.getElementById("nameText");
	var oAgeText = document.getElementById("ageText");
	var oButton = document.getElementById("commitButton");
	var oTab = document.getElementById("myTable");
	// var oRow = oTab.tBodies[0].rows;
	oButton.onclick = function() {
		var oTr = document.createElement("tr");

		var oTd = document.createElement("td");
		oTd.innerHTML = oTab.tBodies[0].rows.length + 1;
		oTr.appendChild(oTd);

		var oTd = document.createElement("td");
		oTd.innerHTML = oNameText.value;
		oTr.appendChild(oTd);

		var oTd = document.createElement("td");
		oTd.innerHTML = oAgeText.value;
		oTr.appendChild(oTd);

		oTab.tBodies[0].appendChild(oTr);
	}
}

// table 脚本1
window.onload = function() {
	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;
	var oldColor;
	for(var i = 0; i < oRow.length; i++) {
		oRow[i].onmouseover = function() {
			oldColor = this.style.background;
			this.style.background = "rgb(95,151,43)";
		}
		oRow[i].onmouseout = function() {
			this.style.background = oldColor;
		}
 		if(i % 2) {
			oRow[i].style.background = "#ccc";
		}
		else {
			oRow[i].style.background = "";
		}
	}
}
*/