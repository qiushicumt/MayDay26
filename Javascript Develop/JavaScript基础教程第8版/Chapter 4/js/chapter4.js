/*
// 4-1 脚本
function changeRed() {
	document.getElementById("arrow").src = '../images/arrow_on.gif';
}
function changeBlack() {
	document.getElementById("arrow").src = '../images/arrow_off.gif';
}
*/
// 4-2 脚本
function changeRed() {
	document.images['arrow'].src = '../images/arrow_on.gif';
}
function changeBlack() {
	document.images['arrow'].src = '../images/arrow_off.gif';
}

// 4-3 脚本
window.onload = rolloverInit;
function rolloverInit() {
	// document.images, images集合返回当前文档中所有图片的数组
	for(var i = 0; i < document.images.length; i++) {
		if (document.images[i].parentNode.tagName == "A") {
			setupRollover(document.images[i]);
		}
	}
}
function setupRollover(thisImage) {

	thisImage.outImage = new Image();
	thisImage.outImage.src = thisImage.src;
	thisImage.onmouseout = function() {
		this.src = this.outImage.src;
	}

	thisImage.overImage = new Image();
	// alert(thisImage.id);
	thisImage.overImage.src = "../images/" + thisImage.id + "_on.gif";
	thisImage.onmouseover = function() {
		this.src = this.overImage.src;
	}
}
