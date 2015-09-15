var timer = null;
window.onload = function() {
	oDiv = document.getElementById("div1");
	oDiv.style.left = -200 + "px";
	oDiv.onmouseover = moveOut;
	odiv.onmouseout = moveIn;
}
function moveOut() {
	clearInterval(timer);
	timer = setInterval(function(){
		if(oDiv.offsetLeft >= 0) {
			clearInterval(timer);
		}
		else {
			oDiv.style.left = oDiv.offsetLeft + 5 + "px";
		}
	}, 30);
}
function moveIn() {
	
}