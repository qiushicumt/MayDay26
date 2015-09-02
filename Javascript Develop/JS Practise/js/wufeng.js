window.onload = function() {
	oDiv = document.getElementById("wrappage");
	oUl = oDiv.getElementsByTagName("ul")[0];
	var timer;
	oUl.innerHTML = oUl.innerHTML + oUl.innerHTML;
	function movefunc() {
		oUl.style.left = oUl.offsetLeft - 2 + "px";
		if(oUl.offsetLeft == (-parseInt(window.getComputedStyle(oDiv, null).width))) 
			oUl.style.left = 0 + "px";
	}
	timer = setInterval(movefunc, 30);

	oDiv.onmouseover = function() {
		clearInterval(timer);
	}

	oDiv.onmouseout = function() {
		timer = setInterval(movefunc, 30);
	}
}

/*
// 无缝滚动脚本 2
window.onload = function() {
	oUl = document.getElementsByTagName("ul");
	oDiv = document.getElementById("wrappage");
	var timer;
	oUl[0].innerHTML = oUl[0].innerHTML + oUl[0].innerHTML;
	console.log(oUl[0].innerHTML);
	
	function moveFunc() {
		oUl[0].style.left = (parseInt(oUl[0].style.left) +2) + "px"; 
	}
	timer = setInterval(moveFunc, 20);
	
}

// 无缝滚动脚本 1
window.onload = function() {
	var oUl = document.getElementsByTagName("ul");
	var oDiv = document.getElementById("wrappage");
	var timer;
	
	oUl[0].style.left = -parseInt(window.getComputedStyle(oDiv).width) + "px";	
	function moveFunc() {
		oUl[0].style.left = (parseInt(oUl[0].style.left) + 2) + "px";
	}

	timer = setInterval(moveFunc, 20);
}
*/