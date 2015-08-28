window.onload = function() {
	oUl = document.getElementsByTagName("ul");
	oDiv = document.getElementById("wrappage");
	var timer;
	oUl[0].innerHTML = oUl[0].innerHTML + oUl[0].innerHTML;
	console.log(oUl[0].innerHTML);

	// function moveFunc() {
	// 	oUl[0].style.left = (parseInt(oUl[0].style.left) +20) + "px";
	// }
	// setTimeout(moveFunc, 1000);

	
	function moveFunc() {
		oUl[0].style.left = (parseInt(oUl[0].style.left) +2) + "px"; 
	}
	timer = setInterval(moveFunc, 20);
	
}


/*
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