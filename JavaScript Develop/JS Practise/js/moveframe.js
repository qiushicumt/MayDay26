// 多物体、任意属性运动 最终脚本
window.onload = function() {
	var theDiv = document.getElementById("wrappage");
	var oDiv = theDiv.getElementsByTagName("div");
	for(var i = 0; i < oDiv.length; i++) {
		oDiv[i].timer = null;
	}
	oDiv[0].onmouseover = function() {moveFunc(this, 'height', 400);}
	oDiv[0].onmouseout = function() {moveFunc(this, 'height', 150);}
	oDiv[1].onmouseover = function() {moveFunc(this, 'width', 400);}
	oDiv[1].onmouseout = function() {moveFunc(this, 'width', 150);}
	oDiv[2].onmouseover = function() {moveFunc(this, 'fontSize', 30);}
	oDiv[2].onmouseout = function() {moveFunc(this, 'fontSize', 14);}
	oDiv[3].onmouseover = function() {moveFunc(this, 'borderWidth', 30);}
	oDiv[3].onmouseout = function() {moveFunc(this, 'borderWidth', 4);}
	oDiv[4].onmouseover = function() {moveFunc(this, 'opacity', 100);}
	oDiv[4].onmouseout = function() {moveFunc(this, 'opacity', 30);}
}
function getStyle(obj, attr) {
	if(obj.currentStyle) {
		return obj.currentStyle(attr);
	}
	else {
		return getComputedStyle(obj, null)[attr];
	}
}
function moveFunc(obj, attr, iTarget) {
	clearInterval(obj.timer);
	obj.timer = setInterval(function() {
		var cur;
		if(attr == 'opacity') {
			cur = Math.round(getStyle(obj, attr)*100);
		}
		else {
			cur = parseInt(getStyle(obj, attr));
		}
		var speed = (iTarget - cur)/6;
		speed = speed>0 ? Math.ceil(speed) : Math.floor(speed);
		if(cur == iTarget) {
			clearInterval(obj.timer);
		}
		else {
			if(attr == 'opacity') {
				obj.style['filter'] = 'alpha(opacity:' + (cur + speed) + ');';
				obj.style[attr] = (cur + speed)/100;
			}
			else {
				obj.style[attr] = cur + speed + 'px';
			}
		}
	}, 30);
}
/*
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
*/