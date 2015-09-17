// 淡入淡出脚本
window.onload = function() {
	var oDiv = document.getElementById("div1");
	oDiv.onmouseover = function() {filterChange(100);}
	oDiv.onmouseout = function() {filterChange(20);}
}
var timer = null;
var alpha = 60;
function filterChange(iTarget) {
	var oDiv = document.getElementById("div1");	
	clearInterval(timer);
	timer = setInterval(function() {
		if(alpha < iTarget) {
			alpha = alpha + 10;
		}
		else {
			alpha = alpha - 10;
		}
		if(alpha === iTarget) {
			clearInterval(timer);
		}
		else {
			oDiv.style.opacity = alpha / 100;
		}
	}, 100);
}