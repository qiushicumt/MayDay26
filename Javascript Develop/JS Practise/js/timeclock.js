// 电子时钟脚本2
window.onload = function() {
	var oDiv1 = document.getElementById("div1");
	var oDiv2 = document.getElementById("div2");
	var weeks = ["星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六"];

	/*
	function timeToChar(n) {
		if(n < 10)
			return "0" + n;
		else
			return "" + n;
	}
	*/
	
	function getTime() {
		var date = new Date();
		// oDiv1.innerHTML = timeToChar(date.getHours()) + ":" + timeToChar(date.getMinutes()) + ":" + timeToChar(date.getSeconds());
		oDiv1.innerHTML = date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds();
		oDiv2.innerHTML = date.getFullYear() + "年" + (date.getMonth() + 1) + "月" + date.getDate() + "日" + weeks[date.getDay()];
	}

	setInterval(getTime, 1000);
	getTime();
}


/*
// 电子时钟脚本1
window.onload = function() {
	var oDiv = document.getElementById("wrappage");
	var oImg = oDiv.getElementsByTagName("img");
	var oDiv1 = document.getElementById("txtTimeClock");
	function timeToChar(n) {
		if(n < 10)
			return "0" + n;
		else
			return "" + n;
	}	
	function setTime() {
		var date = new Date();
		var currentTime = timeToChar(date.getHours()) + timeToChar(date.getMinutes()) + timeToChar(date.getSeconds());

		for(var i = 0; i < oImg.length; i++) {
			oImg[i].src = "../img/" + currentTime.charAt(i) + ".png";
			oDiv1.innerHTML = "<h2>" + timeToChar(date.getHours()) + ":" + timeToChar(date.getMinutes()) + ":" + timeToChar(date.getSeconds()) + "</h2>";
		}
	}
	setInterval(setTime, 1000);
	setTime();
}
*/