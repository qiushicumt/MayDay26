/*
// 3-3 脚本
window.onload = initAll;
function initAll() {
	for(var i = 0; i < 24; i++) {
		// math.random()函数返回0~1之间的随机数，math.floor()函数返回的是小于等于x，且与x最接近的整数
		var num = Math.floor(Math.random() * 75) + 1;		// 随机数是获得0~最大数减1的数，此处要加1
		document.getElementById("square" + i).innerHTML = num;
	}
}
*/
// 3-4 脚本
window.onload = initAll;
function initAll() {
	for (var i = 0; i < 24; i++) {
		setNum(i);
	}
}
function setNum(squareNum) {
	// 错误var currentId = document.getElementById("square" + squareNum);
	var currentId = "square" + squareNum;
	var num = Math.floor(Math.random() * 75) + 1;
	document.getElementById(currentId).innerHTML = num;
}
