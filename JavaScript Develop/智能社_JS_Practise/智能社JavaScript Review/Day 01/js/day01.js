/*
//	效果2、javascript添加class属性
//	方法：给DOM元素添加className属性，可以为元素添加相应的class样式
window.onload = initAll;
function initAll() {	
	var oBtn = document.getElementById("btn1");
	oBtn.onclick = function() {
		changeColor();
	}
}
function changeColor() {
	var oDiv = document.getElementById("div1");
	oDiv.className = "redClass";
}

//	效果3、点击按钮触发事件
//	方法：button元素的onclick事件添加一个function，可以在点击按钮的时候，调用函数
window.onload = initAll;
function initAll() {
	var oBtn = document.getElementById("btn1");
	oBtn.onclick = function() {
		alert(this.value);
	}
}

//	效果4、鼠标悬停显示提示框，鼠标移开提示框消失
//	方法：当鼠标悬停时，onmouseover事件会被触发，调用相应的函数；当鼠标离开时，onmouseout事件会被触发，调用相应的函数
window.onload = initAll;
function initAll() {
	var oBox = document.getElementById("box1");
	oBox.onmouseover = function() {
		divShow();
	}
	oBox.onmouseout = function() {
		divHidden();
	}
}
function divShow() {
	var oDiv = document.getElementById('div1');
	oDiv.style.display = "block";
}
function divHidden() {
	var oDiv = document.getElementById('div1');
	oDiv.style.display = "none";
}

//	效果5、修改title属性
//	方法：直接通过给元素的title属性进行赋值，可以修改元素的title
window.onload = initAll;
function initAll() {
	var oBtn = document.getElementById("btn1");
	oBtn.onclick = function() {
		changeTitle();
	}
	var oTxt = document.getElementById("txt1");
	setTimeout(function(){
		alert(oTxt.title);
	}, 3500);
}
function changeTitle() {
	var oTxt = document.getElementById("txt1");
	oTxt.title = "hduehu";
}

//	效果6、鼠标悬停实现多个属性值的变化
//	方法1：通过onmouseover事件和onmouseout事件，调用相应的函数。在对应的函数中，对元素的每一个想要改变的属性进行赋值，达到改变属性的目的。
window.onload = initAll;
function initAll() {
	var oDiv = document.getElementById("div1");
	oDiv.onmouseover = function() {
		changeFunc();	
	}
	oDiv.onmouseout = function() {
		dischangeFunc();
	}
}
function changeFunc() {
	var oDiv = document.getElementById("div1");
	oDiv.style.width = 150 + "px";
	oDiv.style.height = 150 + "px";
	oDiv.style.backgroundColor = "green";
}
function dischangeFunc() {
	var oDiv = document.getElementById("div1");
	oDiv.style.width = 80 + "px";
	oDiv.style.height = 80 + "px";
	oDiv.style.backgroundColor = "red";
}
*/
//	方法2：通过onmouseover事件和onmouseout事件，调用相应的函数。在对应的函数中，添加className或者移除className可以实现改变属性的目的
window.onload = initAll;
function initAll() {
	var oDiv = document.getElementById("div1");
	oDiv.onmouseover = function() {
		changeClass();
	}
	oDiv.onmouseout = function() {
		dischangeClass();
	}
}
function changeClass() {
	var oDiv = document.getElementById("div1");
	oDiv.className = "changeClass";
}
function dischangeClass() {	
	var oDiv = document.getElementById("div1");
	oDiv.className = "";
}