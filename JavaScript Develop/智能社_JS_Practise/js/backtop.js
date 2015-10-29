window.onload = function(){	
	var oDiv = document.getElementById("div1");
	var oA = oDiv.getElementsByTagName("a")[0];
	
	window.onscroll = function() {
		clearInterval(timer);
		var scrollTop = document.documentElement.scrollTop || document.body.scrollTop;
		
		//	document.title = scrollTop;
		var docHeight = document.documentElement.clientHeight || document.body.clientHeight;
		//	document.title = docHeight;
		// if(scrollTop < 600) {
		// 	oDiv.style.display = "none";
		// }
		// else if(scrollTop >= 600) {
		// 	oDiv.style.display = "block";
		// 	oDiv.style.top = (scrollTop + docHeight - oDiv.offsetHeight - 108) + "px";
		// }
		// timer = setInterval(function(){
		// 	oDiv.style.top = (scrollTop + docHeight - oDiv.offsetHeight - 108) + "px";
		// }, 30);
		oDiv.style.top = (scrollTop + docHeight - oDiv.offsetHeight - 108) + "px";
		// console.log(docHeight + ", " + screenTop + ", " +oDiv.offsetHeight);
	}
	oA.onclick = function(){
		
	}
}
var timer=null;
function startMove(obj, iTarget){
	clearInterval(timer);
	timer = setInterval(function(){
		
	}, 30);
}