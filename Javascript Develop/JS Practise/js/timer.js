/*
window.onload = function() {
	oDiv = document.getElementById("wrappage");
	oImg = oDiv.getElementsByTagName("img");	
			
	// setInterval(A, B)函数设置持续性定时器，A为执行的函数，B为设置的时间间隔，单位为毫秒
	setInterval(function() {
		var oDate = new Date();
		var currentTime = getTime(oDate.getHours()) + getTime(oDate.getMinutes()) + getTime(oDate.getSeconds());
		for(var i = 0; i < oImg.length; i++) {
		oImg[i].src = '../img/' + currentTime.charAt(i) + '.png';
		}
	}, 1000);
}

function getTime(n) {
	if(n < 10) {
		return "0" + n;
	}
	else {
		return "" + n;
	}
};
*/
window.onload = function() {
	var oDiv = document.getElementById("wrappage");
	var oImg = oDiv.getElementsByTagName("img");
	// 获取的系统当前时间为数字，通过setDate函数将数字转换为字符串
	function setDate(n) {
		if (n < 10) {
			return "0" + n;
		}
		else {
			return "" + n;
		}
	}
	// 定时器每秒需要执行的函数，根据获得的系统当前时间，改变显示的时钟图片
	function timer() {
		for(var i = 0; i < oImg.length; i++) {
			var oDate = new Date();
			var currentTime = setDate(oDate.getHours()) + setDate(oDate.getMinutes()) + setDate(oDate.getSeconds());
			oImg[i].src = '../img/' + currentTime.charAt(i) + '.png';
		}
	}
	// 调用定时器函数（定时器函数在页面加载完成以后有一秒钟的延迟）
	setInterval(timer, 1000); 
	timer();	
}