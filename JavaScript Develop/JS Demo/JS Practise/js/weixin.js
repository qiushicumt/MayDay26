window.onload = initAll;
var x=y=z=last_x=last_y=last_z=0;
var lastTime = 0;
var ThresHold = 2400;
function initAll() {
	if(window.DeviceMotionEvent)
	{
		window.addEventListener("devicemotion", deviceMotionHandler, false);
	}
	else 
	{
		alert("Your browser don't support this script!");
	}
}

function deviceMotionHandler(eventData) {
	var acceleration = eventData.accelerationIncludingGravity;
	var currentTime = new Date().getTime();
	var time = currentTime - lastTime;
	
	//	判断两次移动的间隔，间隔大于100表明是两次摇动
	if(time>100)
	{
		lastTime = currentTime;
		x = acceleration.x;
		y = acceleration.y;
		z = acceleration.z;
		
		//	求摇晃的速率
		var speed = Math.abs(x+y+z-last_x-last_y-last_z)/time * 10000;
		if(speed>ThresHold)
		{
			/*
			//	alert("x = "+x+", y = "+y+", z="+z);
			var oXDiv = document.getElementById('myXTxt');
			var oYDiv = document.getElementById('myYTxt');
			var oZDiv = document.getElementById('myZTxt');
			
			var xSpan = oXDiv.getElementsByTagName('span')[0];
			var ySpan = oYDiv.getElementsByTagName('span')[0];
			var zSpan = oZDiv.getElementsByTagName('span')[0];
			
			xSpan.innerHTML = x;
			ySpan.innerHTML = y;
			zSpan.innerHTML = z;
			*/
			
			//	Math.random()：产生一个0-1之间的随机数
			//	Math.floor()：向下四舍五入取整
			//	Math.ceil()：向上四舍五入取整
			
			var num = Math.ceil(Math.random());
			
		}
		last_x = x;
		last_y = y;
		last_z = z;
	}
}
