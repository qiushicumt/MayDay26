//	6.4	作用域

/*
//	6.4.1	全局变量和局部变量
//	示例代码中，第一个x为全局变量。在函数fn中，第一个输出语句中的x是fn中的后面声明的局部变量。
//	在函数中声明的局部变量在整个函数中都可以访问。第一个输出语句访问x的时候，x还没有被赋值，所以此时x=undefined
var x = 1;
function fn(){
	console.log("x = " + x);	//	x=undefined
	var x = 2;
	console.log("x = " + x);	//	x=2
}
fn();

//	6.4.2	块级作用域	在JavaScript中不存在块级作用域的概念，只有函数外的全局变量和函数内的局部变量
function fn() {
	var i = 1;
	var result = new Array(10);
	for(var i = 0; i < result.length; i++) {
		result[i] = i;
	}
	alert(i);		//因为不存在块级作用域，所以i就是整个fn函数内的i，i在for循环中自加到10，所以输出10
}
fn();

//	6.4.3	let实现块级作用域	let使用方法与var类似，在块级代码中使用let声明的变量，具有块级作用域的效果
function fn() {
	var i = 1;
	var result = new Array(10);
	for(let i = 0; i < result.length; i++) {
		result[i] = i;
	}
	alert(i);		//	输出i=1；for循环中，使用let声明的i仅在for循环中有效。
}
fn();
*/