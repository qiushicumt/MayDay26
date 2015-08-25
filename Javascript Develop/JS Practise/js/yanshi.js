window.onload = function() {
	var oDiv1 = document.getElementById("div1");
	var oDiv2 = document.getElementById("div2");
	var timer = null;		// 定义一个全局定时器

	oDiv1.onmouseover = function() {
		clearTimeout(timer);
		oDiv2.style.display = 'block';
	}

	oDiv1.onmouseout = function() {
		timer = setTimeout(function() {
			oDiv2.style.display = 'none';
		}, 500);
	}

	oDiv2.onmouseover = function() {
		clearTimeout(timer);
	}

	oDiv2.onmouseout = function() {
		timer = setTimeout( function() {
			oDiv2.style.display = 'none';
		}, 200);		
	}
}