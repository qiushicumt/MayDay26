window.onload = function() {
	var theDiv = document.getElementById("wrappage");
	var oDiv = theDiv.getElementsByTagName("div");
	for(var i = 0; i < oDiv.length; i++) {
		oDiv[i].timer = null;
	}
	// 第一个div变高
	oDiv[0].onmouseover = function() {
		moveFunc(this, "height", 400);
	}
	oDiv[0].onmouseout = function() {
		moveFunc(this, "height", 150);
	}
	// 第二个div变宽
	oDiv[1].onmouseover = function() {
		moveFunc(this, 'width', 400);
	}
	oDiv[1].onmouseout = function() {
		moveFunc(this, "width", 150);
	}

}
function getStyle(obj, name) {	
	if(obj.currentStyle) {				
		return obj.currentStyle[name];		
	}
	else {
		return getComputedStyle(obj, null)[name];
	}
}
function moveFunc(obj, styleName, iTarget) {
	clearInterval(obj.timer);	
	obj.timer = setInterval(function(){
		var cur = parseInt(getStyle(obj, styleName));
		var speed = (iTarget - cur)/6;
		speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);
		if(cur == iTarget) {
			clearInterval(obj.timer);
		}
		else {
			obj.style[styleName] = cur + speed + "px";
		}
	}, 30);
}