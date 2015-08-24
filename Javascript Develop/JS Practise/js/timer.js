window.onload = function() {
	oDiv = document.getElementById("wrappage");
	oImg = oDiv.getElementsByTagName("img");

	var oDate = new Date();
	var currentTime = getTime(oDate.getHours()) + getTime(oDate.getMinutes()) + getTime(oDate.getSeconds());

	for(var i = 0; i < oImg.length; i++) {

	}
	
}

function getTime(n) {
	if(n < 10) {
		return "0" + n;
	}
	else {
		return "" + n;
	}
}