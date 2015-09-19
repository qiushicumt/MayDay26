// 脚本3  多个div的颜色淡入淡出效果
window.onload = function() {
	var theDiv = document.getElementById("wrappage");
	var oDiv = theDiv.getElementsByTagName("div");
	for(var i = 0; i < oDiv.length; i++) {
		oDiv[i].timer = null;
		oDiv[i].onmouseover = function() {
			moveFunc(this, 100);
		}
		oDiv[i].onmouseout = function() {
			moveFunc(this, 30);
		}
	}
}
var alpha = 30;
function moveFunc(obj, iTarget) {
	clearInterval(obj.timer);
	obj.timer = setInterval(function(){
		var speed = (iTarget - alpha)/6;
		speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);
		if(alpha == iTarget) {
			clearInterval(obj.timer);
		}
		else {
			// alpha += speed;
			// 错误 obj.style.opacity = alpha + speed;
			// 错误原因是 alpha+speed只是改变了一次当前div的透明度值，而alpha变量自身并没有发生变化 
			alpha += speed;
			obj.style.filter = "alpha(opacity:" + alpha + ")";
			obj.style.opacity = alpha/100;
		}
	}, 30);
}
/*
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