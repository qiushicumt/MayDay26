// 侧边栏淡入淡出--缓冲方式
window.onload = function() {
	var oDiv = document.getElementById("div1");
	oDiv.style.left = -160 + "px";
	oDiv.onmouseover = function() {
		moveFunc(0);
	}
	oDiv.onmouseout = function() {
		moveFunc(-160);
	}
}
var timer = null;
function moveFunc(iTarget) {
	clearInterval(timer);
	var oDiv = document.getElementById("div1");
	timer = setInterval(function(){
		var speed = (iTarget - oDiv.offsetLeft)/10;
		speed = speed>0?Math.ceil(speed):Math.floor(speed);
		if(oDiv.offsetLeft == iTarget) {
			clearInterval(timer);
			// alert("ok1");
		}
		else {
			oDiv.style.left = oDiv.offsetLeft + speed + "px";
			// alert("ok2");
		}	
	}, 30);
}
/*
// 右侧悬浮窗缓冲运动--中间
window.onscroll = function() {
	var oDiv = document.getElementById("div1");
	var scrollTop = document.documentElement.scrollTop || document.body.scrollTop;
	moveFunc(parseInt((document.documentElement.clientHeight - oDiv.offsetHeight)/2 + scrollTop));
}
var timer = null;
function moveFunc(iTarget) {
	clearInterval(timer);
	var oDiv = document.getElementById("div1");
	timer = setInterval(function(){
		var speed = (iTarget - oDiv.offsetTop)/6;
		speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);
		if(oDiv.offsetTop == iTarget) {
			clearInterval(timer);
		}
		else {
			oDiv.style.top = oDiv.offsetTop + speed + "px";
			console.log(oDiv.offsetTop);
		}
	},30);
}

// 右侧悬浮窗口缓冲运动--右下角
window.onscroll = function() {
	var oDiv = document.getElementById("div1");
	var scrollTop = document.documentElement.scrollTop||document.body.scrollTop;
	moveFunc(document.documentElement.clientHeight - oDiv.offsetHeight + scrollTop);
}
var timer = null;
function moveFunc(iTarget) {
	clearInterval(timer);
	var oDiv = document.getElementById("div1");
	timer = setInterval(function() {
		var speed = (iTarget - oDiv.offsetTop)/6;
		speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);
		if(oDiv.offsetTop == iTarget) {
			clearInterval("timer");
		}
		else {
			oDiv.style.top = oDiv.offsetTop + speed + "px";
		}
	}, 30);
}

// div缓冲运动脚本
window.onload = function() {
	var oDiv = document.getElementById("div1");
	var oBtn = document.getElementById("btn1");
	var iTarget = 300;
	var timer = null;
	var speed;
	oBtn.onclick = function() {
		clearInterval(timer);
		timer = setInterval(function() {
			// Math.ceil()方法用于将数字向上取整，即 Math.ceil(3.18)的值为4	
			// speed = Math.ceil((iTarget - oDiv.offsetLeft) / 30); 
			// speed = Math.floor((iTarget - oDiv.offsetLeft)/30);
			// speed = iTarget - oDiv.offsetLeft;
			// speed?(speed=Math.ceil(speed)/30):(speed=Math.floor(speed)/30);
			if(iTarget > oDiv.offsetLeft) {
				speed = Math.ceil((iTarget - oDiv.offsetLeft) / 20);
			}
			else {
				speed = Math.floor((iTarget - oDiv.offsetLeft) / 20);
			}
			if(oDiv.offsetLeft == iTarget) {
				clearInterval(timer);
			}
			else {
				oDiv.style.left = oDiv.offsetLeft + speed + "px";
			}
		}, 30);
	}
}
*/