// 脚本3
window.onload = function() {
	addRow();
	sortRow();
}
function addRow() {
	var oName = document.getElementById("nameText");
	var oNumber = document.getElementById("numberText");

	var oBtn1 = document.getElementById("btn1");

	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;
	var id = oRow.length;

	oBtn1.onclick = function() {
		var oTr = document.createElement("tr");
		var oTd = document.createElement("td");
		oTd.innerHTML = ++id;
		oTr.appendChild(oTd);
		var oTd = document.createElement("td");
		oTd.innerHTML = oName.value;
		oTr.appendChild(oTd);
		var oTd = document.createElement("td");
		oTd.innerHTML = oNumber.value;
		oTr.appendChild(oTd);
		oTab.tBodies[0].appendChild(oTr);
	}
}
function sortRow() {
	var oBtn2 = document.getElementById("btn2");
	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;

	oBtn2.onclick = function() {
		var rowArray = new Array();
		for(var i = 0; i < oRow.length; i++) {
			rowArray[i] = oRow[i];
		}
		rowArray.sort(function(tr1, tr2) {
			var n1 = tr1.cells[0].innerHTML;
			var n2 = tr2.cells[0].innerHTML;
			return n1 - n2;
		});
		for(var i = 0; i < rowArray.length; i++) {
			oTab.tBodies[0].appendChild(rowArray[i]);
			console.log(rowArray[i].innerHTML);
		}
	}
}

/*
// 脚本2
window.onload = function() {
	addTable();
	sortTable();
}
function addTable() {
	var oBtn1 = document.getElementById("btn1");
	var oName = document.getElementById("nameText");
	var oNumber = document.getElementById("numberText");

	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;

	var id = oRow.length;

	oBtn1.onclick = function() {
		var oTr = document.createElement("tr");
		var oTd = document.createElement("td");
		oTd.innerHTML = ++id;
		oTr.appendChild(oTd);
		var oTd = document.createElement("td");
		oTd.innerHTML = oName.value;
		oTr.appendChild(oTd);
		var oTd = document.createElement("td");
		oTd.innerHTML = oNumber.value;
		oTr.appendChild(oTd);
		oTab.tBodies[0].appendChild(oTr);
	}
} 
function sortTable() {
	var oBtn2 = document.getElementById("btn2");
	var oTab = document.getElementById("myTable");
	var oRow = oTab.tBodies[0].rows;

	oBtn2.onclick = function() {
		var idArray = new Array();
		for(var i = 0; i < oRow.length; i++) {
			idArray.push(oRow[i].cells[0].innerHTML);
		}
		idArray.sort(function(id1, id2){
			return id1 - id2;
		});
		for(var i = 0; i < idArray.length; i++) {
			for(var j = 0; j < oRow.length; j++) {
				if(idArray[i] == oRow[j].cells[0].innerHTML)
					oTab.tBodies[0].appendChild(oRow[j]);
			}
		}
	}
}

// 脚本1
window.onload = function() {
	var oUl1 = document.getElementById("ul1");
	var oUl2 = document.getElementById("ul2");
	var oBtn = document.getElementById("btn1");

	oBtn.onclick = function() {
		var oLi = oUl1.getElementsByTagName("li");
		if(oLi.length > 0)
			oUl2.appendChild(oLi[0]);
		else
			alert("Ul1 is empty!");
	}
}
*/