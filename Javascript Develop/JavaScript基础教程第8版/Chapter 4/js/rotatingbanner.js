window.onload = rotateInit;
var thisAd = 0;
var timer;
function rotateInit() {
	var thisImage = new Array("../images/reading1.gif", "../images/reading2.gif", "../images/reading3.gif");
	thisAd++;
	if(thisAd == thisImage.length) {
		thisAd = 0;
	}
	document.getElementById("adBanner").src = thisImage[thisAd];
	timer = setTimeout(rotateInit, 2000);
	document.getElementById("adBanner").onmouseover = function(){
		clearTimeout(timer);
	}
	document.getElementById("adBanner").onmouseout = function() {
		timer = setTimeout(rotateInit, 2000);
	}
}
