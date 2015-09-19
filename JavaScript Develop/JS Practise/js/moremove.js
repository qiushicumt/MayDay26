// 脚本2  各自触发事件使用各自的定时器
window.onload = function() {
	var theDiv = document.getElementById("wrappage");
	var oDiv = theDiv.getElementsByTagName("div");
	for(var i = 0; i < oDiv.length; i++) {
		oDiv[i].timer = null;
		oDiv[i].onmouseover = function() {
			moveFunc(this, 400);
		}
		oDiv[i].onmouseout = function() {
			moveFunc(this, 100);
		}
	}
}
function moveFunc(obj, iTarget) {
	clearInterval(obj.timer);
	obj.timer = setInterval(function(){
		var speed = (iTarget - obj.offsetWidth)/6
		speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);

		if(obj.offsetWidth == iTarget) {
			clearInterval(obj.timer);
		}
		else {
			obj.style.width = obj.offsetWidth + speed + "px";
		}
	}, 30);
}
/*
// 脚本1  三个触发事件使用同一个定时器
window.onload = function() {
	var oDiv = document.getElementById("wrappage");
	var div1 = oDiv.getElementsByTagName("div");
	for(var i = 0; i < div1.length; i++) {
		div1[i].onmouseover = function() {
			moveFunc(this, 400);
		}
		div1[i].onmouseout = function() {
			moveFunc(this, 100);
		}
	}
 }
var timer = null;

function moveFunc(obj,iTarget) {
	clearInterval(timer);
	timer = setInterval(function(){

		var speed = (iTarget - obj.offsetWidth)/6;
		speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);

		if(obj.offsetWidth == iTarget) {
			clearInterval(timer);
		}
		else {
			obj.style.width = obj.offsetWidth + speed + "px";
		}
	}, 30);
}
*/