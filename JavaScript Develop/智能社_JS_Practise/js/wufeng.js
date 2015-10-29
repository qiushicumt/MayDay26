// 无缝滚动脚本 5
window.onload = function() {
	var oDiv = document.getElementById("wrappage");
	var oUl = oDiv.getElementsByTagName("ul")[0];
	var oLi = oUl.getElementsByTagName("li");
	var timer;
	var oLeftButton = document.getElementById("leftButton");
	var oRightButton = document.getElementById("rightButton");
	var speed = 2;

	oUl.innerHTML += oUl.innerHTML;
	oUl.style.width = oLi[0].offsetWidth * oLi.length + "px";

	function moveFunc() {
		if(oUl.offsetLeft < -oUl.offsetWidth/2) {
			oUl.style.left = 0;
		}
		console.log(oUl.offsetLeft);
		if(oUl.offsetLeft > 0) {
			oUl.style.left = -oUl.offsetWidth/2 + "px";
			console.log(oUl.style.left);
		}			
		oUl.style.left = oUl.offsetLeft + speed + "px";
	}
	timer = setInterval(moveFunc, 30);

	oDiv.onmouseover = function() {
		clearInterval(timer);
	}
	oDiv.onmouseout = function() {
		timer = setInterval(moveFunc, 30);
	}

	oLeftButton.onmouseover = function() {
		speed = -2;
	}
	oRightButton.onmouseover = function() {
		speed = 2;
	}
}

/*
// 无缝滚动脚本 4
window.onload = function() {
	var oDiv = document.getElementById("wrappage");
	var oUl = oDiv.getElementsByTagName("ul")[0];
	var oLi = oUl.getElementsByTagName("li");
	var timer;
	oUl.innerHTML = oUl.innerHTML + oUl.innerHTML;	// 将ul的内容复制一下，使ul变成内容两个相同的
	oUl.style.width = oLi[0].offsetWidth * oLi.length + "px";	//设置ul的宽度，使ul下所有的li能够在一行中显示
	
	function moveFunc() { 
		// ul向左移动，ul的左边距offsetLeft一直为负值，所以与-(ul的offsetWidth/2)比较
		if(oUl.offsetLeft < -oUl.offsetWidth/2)
			oUl.style.left = 0;
		oUl.style.left = oUl.offsetLeft - 2 + "px";
	}
	timer = setInterval(moveFunc, 30);

	oDiv.onmouseover = function() {
		clearInterval(timer);
	}
	oDiv.onmouseout = function() {
		timer = setInterval(moveFunc, 30);
	}
}

// 无缝滚动脚本 3
window.onload = function() {
	var oDiv = document.getElementById("wrappage");
	var oUl = oDiv.getElementsByTagName("ul")[0];
	var oDiv1 = document.getElementById("buttonDiv");
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