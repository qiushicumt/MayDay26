/*
window.onload = initAll;
function initAll() {
	document.addEventListener("click", function(){
		alert("ok1");
	});
}

window.onload = initAll;
function initAll() {
	window.addEventListener("resize", function(){
		alert("ok1");
	})	
}

//	target.addEventListener(type, listener[, useCapyure])
//	给元素或者document或者window注册一个事件监听器，
//	type为字符串，是一个表示事件类型的字符串，如'click'、'resize'等
//	listener[]，是事件触发时所调用的函数
//	useCapture表示是否捕获，默认为false，表示不捕获
window.onload = initAll;
function initAll() {
	var SHAKEHOLD = 3000;			//	设定一个摇动的阈值
	var last_update = 0;			//	用于保存上一次的时间
	var x=y=z=last_x=last_y=last_z=0;		//x、y、z用于保存当前3个轴的数据，last_x、last_y、last_z用于保存上一次的3个轴的数据
	if(window.DeviceMotionEvent)
	{
		window.addEventListener('devicemotion', deviceMotionHandler, false);
	}
	else {
		alert("Your browser don't support this script!");
	}
}
function deviceMotionHandler(eventData) {
	var oDiv = document.getElementById('myTxt');
	var oSpan = oDiv.getElementsByTagName('span')[0];
	oSpan.innerHTML = event.accelerationIncludingGravity.x
	//	var acceleration=eventData.accelerationIncludingGravity;
	var acceleration = eventData.acceleration
}
*/

window.onload = initAll;
var lastTime = 0;		//	设置上一次运动的时间戳
var Shake_Threshold = 2400;
var x=0, y=0, z=0, last_x=0, last_y=0, last_z=0;	//
function initAll() {	
	//	错误：if(window.DeviceMotion) {		
	
	//	判断浏览器是否支持封装的运动传感器组件
	if(window.DeviceMotionEvent) {
		//	添加事件监听器，监测用户摇动手机，摇动手机时触发函数
		window.addEventListener("devicemotion", ShakeHandler, false);
	}
	else {
		alert("Your browser don't support this script!!");
	}	
}
function ShakeHandler(eventData) {
	var accelaration = eventData.accelarationIncludingGravity;
	var currentTime = new Date().getTime();
	var time = currentTime - lastTime;
	x = accelaration.x;
	y = accelaration.y;
	z = accelaration.z;
	//	错误：var speed = (x+y+z-last_x-last_y-last_z)/time * 10000;
	var speed = Math.abs(x+y+z-last_x-last_y-last_z)/time * 10000;
	if(speed > Shake_Threshold)
	{
		var xTxt = document.getElementById('myXTxt');
		var xSpan = xTxt.getElementsByTagName('span')[0];
		xSpan.innerHTML = x.toString();
		var yTxt = document.getElementById('myYTxt');
		var ySpan = yTxt.getElementsByTagName('span')[0];
		ySpan.innerHTML = y.toString();
		var zTxt = document.getElementById('myZTxt');
		var zSpan = zTxt.getElementsByTagName('span')[0];
		zSpan.innerHTML = z.toString();
	}
	last_x = x;
	last_y = y;
	last_z = z;
}