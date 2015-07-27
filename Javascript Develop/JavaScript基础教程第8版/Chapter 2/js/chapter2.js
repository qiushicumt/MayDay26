/*
// 2-8 脚本
var ans = prompt("Are you sure you want to do that?","");
if(ans)
	alert("You said " + ans);
else
	alert("You refused to answer question.");

// 2-9 脚本
window.onload = initAll;
function initAll() {
	document.getElementById("redirect").onclick = initRedirect;
}
function initRedirect() {
	window.location = "../html/jswelcome.html";
	// alert("1");
	// 停止对用户单击的处理
	return false;	
}

// 2-13 脚本
window.onload = initAll;
function initAll() {
	document.getElementById("redirect").onclick = initRedirect;
}
function initRedirect() {
	alert("You are opening the new website");
	// window.location = "../html/jswelcome.html";
	window.location = this;
	return false;
}

// 2-15 脚本
window.onload = initAll;
function initAll() {
	document.getElementById("Lincoln").onclick = saySomething;
	document.getElementById("Kennedy").onclick = saySomething;
	document.getElementById("Nixon").onclick = saySomething;
}
function saySomething() {
	switch (this.id) {
		case "Lincoln":
			alert("You have clicked Lincoln button");
			break;
		case "Kennedy":
			alert("You have clicked Kennedy button");
			break;
		case "Nixon":
			alert("You have clicked Nixon button");
			break;
		default:
			break;
	}
}
*/
window.onload = initAll;
function initAll() {
	var num = prompt("Please enter a number:","");		// prompt函数用于获取用户输入
	try {												// try...catch...函数用于捕获错误
		if(!num || isNaN(num) || num < 0) {			
			throw new Error("Not a valid number.");		// 输入数据格式错误时，此会抛出错误，后面的语句不会被执行，
		}												// Error会传递给catch
		alert("The square root of " + num + " is " + Math.sqrt(num));
	}
	catch(errMsg) {
		alert(errMsg.message);
	}
}