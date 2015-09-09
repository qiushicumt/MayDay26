// 5-1 脚本
/*
window.onload = function() {
	if(top.location != self.location)
		top.location.replace(self.location);
}

// 5-2 脚本1
window.onload = function() {
	var linkArray = new Array("http://www.baidu.com", "http://www.126.com", "http://www.163.com");
	var index;
	for(var i = 0; i < document.links.length; i++) {
		document.links[i].index = i;
		document.links[i].target = "icontent";
			document.links[i].onclick = function() {
			this.href = linkArray[index];
		}
	}
}

// 5-2 脚本2
window.onload = function() {
	var oLink = document.links;
	for(var i = 0; i < oLink.length; i++) {
		oLink[i].target = "icontent";	// 将链接的target目标设置到iframe中
	}
}

// 5-3 脚本
window.onload = function() {
	var oLink = document.links;
	for(var i = 0; i < oLink.length; i++) {
		oLink[i].onclick = setLink;
	}
}
function setLink() {
	document.getElementById("icontent").contentWindow.document.location.href = this.href;
	return false;
}

// 5-4 脚本
window.onload = function() {
	var oLink = document.links;
	for(var i = 0; i < oLink.length; i++) {
		if(oLink[i].className == "newWin")
			oLink[i].onclick = newWindow;
	}
}
function newWindow() {
	// 重新创建一个window窗口，打开此窗口，参数为窗口的相关属性设置
	var catWindow = window.open("../images/pixel1.jpg", "catWin", "resizable=no,width=350,height=260");	// var windowObjectReference = window.open(strUrl, strWindowName, [strWindowFeatures]);
	return false;
} 

// 5-5 脚本1
window.onload = function() {
	var oLink = document.links;
	for(var i = 0; i < oLink.length; i++) {
		if(oLink[i].className == "newWin")
			oLink[i].onclick = newWindow;
	}
}
function newWindow() {
	var catWindow = window.open(this.href, "catWin", "width=350,height=260");
	catWindow.focus();
	return false;
}
*/
// 5-5 脚本2
var catArray = new Array("../images/pixel1.jpg", "../images/pixel2.jpg", "../images/pixel3.jpg", "../images/pixel4.jpg");
window.onload = function() {	
	var oLink = document.links;
	for(var i = 0; i < oLink.length; i++) {
		if(oLink[i].className = "newWin") {
			oLink[i].onclick = newWindow(i);
		}
	}		
}
function newWindow(index) {
	// alert(catArray[index]);
	var catWindow = window.open(catArray[index], "catWin", "resizable=no,width=350,height=260");
	// catWindow.focus();
	return false;
}









