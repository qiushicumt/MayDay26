// 最终脚本
window.onload = function() {
	oDiv = document.getElementById("div1");
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
	timer = setInterval(function(){
		if(oDiv.offsetLeft == iTarget) {
			clearInterval(timer);
		}
		else {
			var speed;
			if(oDiv.offsetLeft < iTarget) {
				speed = 8;
			}
			else {
				speed = -8;
			}
			oDiv.style.left = oDiv.offsetLeft + speed + "px";
		}
	}, 30);
}
/*
// 脚本3  根据目标距离，设定speed值
window.onload = function() {
	oDiv = document.getElementById("div1");
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
	timer = setInterval(function() {
		if(oDiv.offsetLeft == iTarget) {
			clearInterval(timer);
		}
		else {
			if((oDiv.offsetLeft - iTarget) < 0) {
				var speed = 8;
				oDiv.style.left = oDiv.offsetLeft + speed + "px";
			}
			else {
				var speed = -8;
				oDiv.style.left = oDiv.offsetLeft + speed + "px";
			}
		}
	}, 30);
}

// 脚本2  移入和移出事件触发相同的函数，函数设置形参，根据形参的值得不同，使div移动方向不同
window.onload = function() {
	var oDiv = document.getElementById("div1");
	oDiv.style.left = -160 + "px";
	oDiv.onmouseover = function() {
		moveFunc(8, 0);
	}
	oDiv.onmouseout = function() {
		moveFunc(-8, -160);
	}
}
var timer = null;
function moveFunc(speed, iTarget) {
	var oDiv = document.getElementById("div1");
	clearInterval(timer);
	timer = setInterval(function() {
		if(oDiv.offsetLeft == iTarget) {
			clearInterval(timer);
		}
		else {
			oDiv.style.left = oDiv.offsetLeft + speed + "px";
		}
	}, 30);
}

// 脚本1  移入和移出事件调用的是各自触发的函数方法
var timer = null;
window.onload = function() {
	oDiv = document.getElementById("div1");
	oDiv.style.left = -160 + "px";
	oDiv.onmouseover = moveOut;
	oDiv.onmouseout = moveIn;
}
function moveOut() {
	clearInterval(timer);
	timer = setInterval(function(){
		if(oDiv.offsetLeft == 0) {
			clearInterval(timer);
		}
		else {
			oDiv.style.left = oDiv.offsetLeft + 8 + "px";
		}
	}, 30);
}
function moveIn() {
	clearInterval(timer);
	timer = setInterval(function(){
		if(oDiv.offsetLeft == -160) {
			clearInterval(timer);
		}
		else {
			oDiv.style.left = oDiv.offsetLeft - 8 + "px";
		}
	}, 30);
}
*/