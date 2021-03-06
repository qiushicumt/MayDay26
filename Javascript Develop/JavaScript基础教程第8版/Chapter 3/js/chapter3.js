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

// 3-6 脚本
window.onload = initAll;
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;  // 对超链接进行重定向
		for (var i=0; i<24; i++) {
			setNum(i);
		}
	}
	else {
		alert("Your browser don't support the javascript!");
	}
}
function setNum(squareNum) {
	var squareId = "square" + squareNum;
	var colPlace = new Array(0,0,0,0,0,1,1,1,1,1,2,2,2,2,3,3,3,3,3,4,4,4,4,4);	  
	var Num = colPlace[squareNum] * 15 + Math.floor(Math.random() * 15) + 1; 	// 根据数组中的数字乘以15，用于确定每一列的数值范围的最大值
	document.getElementById(squareId).innerHTML = Num;
}
function reloadWeb() {
	window.location = "BingoCard.html";
	return false;
}

// 3-7 脚本
window.onload = initAll;
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;
		for(var i = 0; i < 24; i++) {
			setNum(i);
		}
	}
	else {
		alert("Your browser don't support this javascript!");
	}
}
function setNum(squareNum) {
	var squareId = "square" + squareNum; 
	var colPlace = new Array(0,0,0,0,0,1,1,1,1,1,2,2,2,2,3,3,3,3,3,4,4,4,4,4);
	var Num = colPlace[squareNum] * 15 + getRandom() + 1;		// getRandom()函数用于获取0~15随机数
	document.getElementById(squareId).innerHTML = Num;
}
function getRandom() {
	return Math.floor(Math.random() * 15); 		// 函数生成一个0~15的随机数并返回
}
function reloadWeb() {
	window.location = "BingoCard.html";
	return false;
}

// 3-8 脚本
window.onload = initAll;
var usedNums = new Array(76);		// 声明一个数组，用于存放每个数字的状态
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;
		for(var i = 0; i < 24; i++) {
			setNum(i);
		}
	}
	else {
		alert("Your browser don't support this script!");
	}
}
function setNum(squareId) {
	var currentId = "square" + squareId;
	var colPlace = new Array(0,0,0,0,0,1,1,1,1,1,2,2,2,2,3,3,3,3,3,4,4,4,4,4);
	var newNum = colPlace[squareId] * 15 + getRandom() + 1;

	// 使用if...else...语句用于对获得的随机数进行状态判断，若之前未产生此随机数，则将此随机数的状态置为1，
	// 存入usedNums数组中，然后将此随机数填入空格内。若之前已经产生此随机数，则转到else语句，调用自身，重
	// 新进行随机数的产生。
	if(!usedNums[newNum]) {	
		usedNums[newNum] = true;
		document.getElementById(currentId).innerHTML = newNum;
	}
	else {
		setNum(squareId);		// 使用递归调用自身，给空格处填上数字
	}
}
function getRandom() {
	return Math.floor(Math.random() * 15);
}
function reloadWeb() {
	window.location = "BingoCard.html";
	return false;
}

// 3-9 脚本
window.onload = initAll;
usedNums = new Array(76);
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;
		for(var i = 0; i < 24; i++) {
			setNum(i);
		}
	}
	else {
		alert("Your browser don't support this script!");
	}
}
function setNum(squareId) {
	var currentId = "square" + squareId;
	var colPlace = new Array(0,0,0,0,0,1,1,1,1,1,2,2,2,2,3,3,3,3,3,4,4,4,4,4);

	do {
		var newNum = colPlace[squareId] * 15 + getRandom() + 1;
	}while(usedNums[newNum]);

	usedNums[newNum] = true;
	document.getElementById(currentId).innerHTML = newNum;
}
function getRandom() {
	return Math.floor(Math.random() * 15);
}
function reloadWeb() {
	window.location = "BingoCard.html";
	return false;
}

// 3-10 脚本
window.onload = initAll;
usedNums = new Array(75);
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;	// 单击超链接，调用reloadWeb函数刷新bingo表
		newCard();
	}
	else {
		alert("Your browser don't support this script.");
	}
}
function newCard() {
	for(var i = 0; i < 24; i++) {
		setNum(i);
	}
}
function setNum(squareId) {
	var currentId = "square" + squareId;
	var colPlace = new Array(0,0,0,0,0,1,1,1,1,1,2,2,2,2,3,3,3,3,3,4,4,4,4,4);
	var newNum;

	do {
		newNum = colPlace[squareId] * 15 + getRandom() + 1;
	}while(usedNums[newNum]);
	usedNums[newNum] = true;
	document.getElementById(currentId).innerHTML = newNum;
}
function getRandom() {
	return Math.floor(Math.random() * 15);
}
// reload函数会把usedNums数组的元素全部重置为0，然后重新调用newCard函数
function reloadWeb() { 
	for(var i = 0; i < usedNums.length; i++) {
		usedNums[i] = false;
	}
	newCard();
	return false;
}

// 3-11 脚本
window.onload = initAll;
usedNums = new Array(76);
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;
		newCard();
	}
	else {
		alert("Your browser don't support this script.");
	}
}
function newCard() {
	for(var i = 0; i <24; i++) {
		setNum(i);
	}
}
function setNum(squareId) {
	var currentId = "square" + squareId;
	var colPlace = new Array(0,0,0,0,0,1,1,1,1,1,2,2,2,2,3,3,3,3,3,4,4,4,4,4);
	var newNum;
	do {
		newNum = colPlace[squareId] * 15 + getRandom() + 1;
	} while(usedNums[newNum]);
	usedNums[newNum] = true;
	document.getElementById(currentId).innerHTML = newNum;
	document.getElementById(currentId).className = "";				// 把当前空格的className设置为""	
	document.getElementById(currentId).onmousedown = toggleColor;	// 设置点击空格调用toggleColor函数
}
function getRandom() {
	return Math.floor(Math.random() * 15);
}
function reloadWeb() {
	for(var i = 0; i < usedNums.length; i++) {
		usedNums[i] = false;
	}
	newCard();
	return false;
}
function toggleColor(evt) {					
	if(evt) {			
		var thisSquare = evt.target;		// 非IE浏览器，获取焦点后会传入evt参数，通过evt.target得到thisSquare对象
	}
	else {
		var thisSquare = window.event.srcElement;	// IE浏览器，需要通过window.event.srcElement得到thisSquare对象
	}
	if(thisSquare.className == "") {
		thisSquare.className = 'pickedBG';		// 将thisSquare对象的className设置为pickedBG，即可以设置css效果
	}
	else {
		thisSquare.className = "";			// 再次点击格子，可以将className重新设置为空，即可以取消背景颜色
	}
}

// 3-12 脚本
window.onload = initAll;
usedNums = new Array(75);
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;
		newCard(); 
	}
	else {
		alert("Your browser don't support this script.");
	}
}
function newCard() {
	for(var i = 0; i < 24; i++) {
		setNum(i);
	}
}
function setNum(squareId) {
	var currentId = "square" + squareId;
	var colPlace = new Array(0,0,0,0,0,1,1,1,1,1,2,2,2,2,3,3,3,3,3,4,4,4,4,4);
	var newNum;
	do {
		newNum = colPlace[squareId] * 15 + getRandom() + 1;
	} while(usedNums[newNum]);
	usedNums[newNum] = true;
	document.getElementById(currentId).innerHTML = newNum;
	document.getElementById(currentId).className = "";
	document.getElementById(currentId).onmousedown = toggleColor;
}
function getRandom() {
	return Math.floor(Math.random() * 15);
}
function reloadWeb() {
	for(var i = 0; i < 24; i++) {
		usedNums[i] = false;
	}
	newCard();
	return false;
}
function toggleColor(evt) {
	if(evt) {
		var thisSquare = evt.target;
	}
	else {
		var thisSquare = window.event.srcElement;		// event.srcElement就是指向触发事件的元素，srcElement 是事件初始目标的html元素对象引用
	}
	if(thisSquare.className == "") {
		thisSquare.className = 'pickedBG';
	}
	else {
		thisSquare.className = "";
	}
	checkWin();
}
function checkWin() {
	var winningOption = -1;		// 存储用户可能遇到的获胜选项
	var setSquare = 0;			// 存储已经单击的格子
	var winners = new Array(31, 992, 15360, 507904, 541729, 557328, 1083458, 2162820, 4329736, 8519745, 8659472, 16252928);		// 数组存储的是有效获胜组合的编码值
	for(var i = 0; i < 24; i++) {
		var currentId = "square" + i;
		if(document.getElementById(currentId).className != "") {
			document.getElementById(currentId).className = 'pickedBG';
			setSquare = setSquare | Math.pow(2, i);		// 对setSquare和数字2的i次方进行按位或操作
		}
	}
	for(var i = 0; i < winners.length; i++) {
		if((winners[i] & setSquare) == winners[i]) {
			winningOption = i;
		}
	}
	if(winningOption > -1) {
		for(var i = 0; i < 24; i++) {
			if(winners[winningOption] & Math.pow(2, i)) {
				currentId = "square" + i;
				document.getElementById(currentId).className = 'winningBG';
			}
		}
	}
}
*/
// 3-13 Buzzword Bingo脚本
var buzzWords = new Array("Aggregate", "Ajax", "API", "Bandwidth", "Beta",
						"Bleeding edge", "Convergence", "Design pattern", "Disruptive", "DRM",
						"Enterprise", "Facilitate", "Folksonomy", "Framework", "Impact",
						"Innovate", "Long tail", "Mashup", "Microformats", "Mobile",
						"Monetize", "Open social", "Paradigm", "Podcast", "Proactive",
						"Rails", "Scalable", "Social bookmarks", "Social graph", "Social software",
						"Spam", "Synergy", "Tagging", "Tipping point", "Truthiness",
						"User-generated", "Vlog", "Webinar", "Wiki", "Workflow");
var usedWords = new Array(buzzWords.length);
window.onload = initAll;
function initAll() {
	if(document.getElementById) {
		document.getElementById("reload").onclick = reloadWeb;
		newCard();
	}
	else {
		alert("Your browser don't support this script.");
	}
}
function newCard() {
	for(var i = 0; i < 24; i++) {
		setSquare(i);
	}
}
function setSquare(squareId) {
	var currentId = "square" + squareId;
	do {
		var randomWord = Math.floor(Math.random() * buzzWords.length);
	} while(usedWords[randomWord]);
	usedWords[randomWord] = true;
	document.getElementById(currentId).innerHTML = buzzWords[randomWord];
	document.getElementById(currentId).className = "";
	document.getElementById(currentId).onmousedown = toggleColor;
}
function toggleColor(evt) {
	if(evt) {
		var thisSquare = evt.target; 
	}
	else {
		var thisSquare = window.event.srcElement;
	}
	if(thisSquare.className == "") {
		thisSquare.className = 'pickedBG';
	}
	else {
		thisSquare.className = "";
	}
	checkWin();
}
function reloadWeb() {
	for(var i = 0; i < 24; i++) {
		usedWords[i] = false;
	}
	newCard();
	return false;
}
function checkWin() {
	var winningOption = -1;
	var setSquare = 0;
	var winners = new Array(31, 992, 15360, 507904, 541729, 557328, 1083458, 2162820, 4329736, 8519745, 8659472, 16252928);
	for(var i = 0; i < 24; i++) {
		var currentId = "square" + i;
		if(document.getElementById(currentId).className != "") {
			document.getElementById(currentId).className = 'pickedBG';
			setSquare = setSquare | Math.pow(2, i);
		}
	}
	for(var i = 0; i < winners.length; i++) {
		if((winners[i] & setSquare) == winners[i]) {
			winningOption = i;
		}
	}
	if(winningOption > -1) {
		for(var i = 0; i < 24; i++) {
			if(winners[winningOption] & Math.pow(2, i)) {
				var currentId = "square" + i;
				document.getElementById(currentId).className = 'winningBG';
			}
		}
	}
}