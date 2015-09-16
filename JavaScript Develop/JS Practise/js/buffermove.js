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