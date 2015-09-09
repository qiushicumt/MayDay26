window.onload = function() {
	oDiv = document.getElementById("wrappage");
	oTab = oDiv.getElementsByTagName("table")[0];
	oRow = oTab.tBodies[0].rows;
	var oldColor;

	for(var i = 0; i < oRow.length; i++) {
		if(i%2) {
			oRow[i].style.background = "rgb(224,211,97)";
		}
		else {
			oRow[i].style.background = "#ccc";
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