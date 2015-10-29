var imgNum = 0;
var rotateImg = new Array("../img/201501.jpg", "../img/201502.jpg", "../img/201503.jpg", "../img/201504.jpg");
window.onload = function() {
	if(document.getElementById) {		
		rotate();
		clickButton();
	}
	else {
		alert("Your browser don't support this script!");
	}
}
function rotate() {
	var oImg = document.getElementById("myImage");
	function timeStart() {
		imgNum++;
		if(imgNum == rotateImg.length)
			imgNum = 0;
		oImg.src = rotateImg[imgNum];
	}
	var timer = setInterval(timeStart, 3500);
	oImg.onmouseover = function() {
		clearInterval(timer);
	}
	oImg.onmouseout = function() {
		timer = setInterval(timeStart, 3500);
	}
}
function clickButton() {
	var oImg = document.getElementById("myImage");
	var oPrevButton = document.getElementById("leftButton");
	var oNextButton = document.getElementById("rightButton");

	oPrevButton.onclick = function() {
		imgNum--;
		if(imgNum < 0) {
			imgNum = rotateImg.length - 1;
		}
		oImg.src = rotateImg[imgNum];
	}
	oNextButton.onclick = function() {
		imgNum++;
		if(imgNum == rotateImg.length) {
			imgNum = 0;
		}
		oImg.src = rotateImg[imgNum];
	}
}