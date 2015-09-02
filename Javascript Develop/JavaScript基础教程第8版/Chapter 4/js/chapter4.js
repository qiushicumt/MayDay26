/*
// 4-1 脚本
function changeRed() {
	document.getElementById("arrow").src = '../images/arrow_on.gif';
}
function changeBlack() {
	document.getElementById("arrow").src = '../images/arrow_off.gif';
}

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

// 4-4 脚本
window.onload = initAll;
function initAll() {
	for (var i = 0; i < document.images.length; i++) {
		if (document.images[i].parentNode.tagName == "A") {
			setupRollover(document.images[i]);
		}
		else {
			alert('Script error or your browser don\'t support this script.');
		}
	}
}
function setupRollover(thisImage) {
	thisImage.outImage = new Image();
	thisImage.outImage.src = thisImage.src;
	thisImage.onmouseout = function() {
		this.src = this.outImage.src;
	}
	thisImage.onclickImage = new Image();
	thisImage.onclickImage.src = '../images/' + thisImage.id + '_click.gif';
	thisImage.onclick = function() {
		this.src = this.onclickImage.src;
	}
	thisImage.overImage = new Image();
	thisImage.overImage.src = '../images/' + thisImage.id + '_on.gif';
	thisImage.onmouseover = function() {
		this.src = this.overImage.src;
	}
}

// 4-5 脚本
window.onload = initAll; 
function initAll() {
	if(document.getElementById) {
		rolloverInit();
	}
	else {
		alert('Your browser don\'t support this script.');
	}
}
function rolloverInit() {
	for(var i = 0; i < document.links.length; i++) {
		var linkObj = document.links[i];	// document.links寻找文档中的链接
		if(linkObj.id) {
			var imgObj = document.getElementById(linkObj.id + 'Img');
			if(imgObj) {
				setupRollover(linkObj, imgObj);
			}
		}
	}
}
function setupRollover(thisLink, thisImage) {
	thisLink.imgToChange = thisImage;
	thisLink.onmouseout = function() {
		this.imgToChange.src = this.outImage.src;
	}
	thisLink.onmouseover = function() {
		this.imgToChange.src = this.overImage.src;
	}
	thisLink.outImage = new Image();
	thisLink.outImage.src = thisImage.src;
	thisLink.overImage = new Image();
	thisLink.overImage.src = '../images/' + thisLink.id + '_on.gif';
}

// 4-6 脚本
window.onload = function() {
	var oLink = document.links;		// 获取文档中的所有链接
	for(var i = 0; i < oLink.length; i++) {
		var linkObj = oLink[i];
		if(linkObj.className) {		// 当链接节点有效时，根据链接节点的className生成正确的img对象
			var imgObj = document.getElementById(linkObj.className);
			if(imgObj) {
				setupRollover(linkObj, imgObj);
			}
		}
	}
}

function setupRollover(thisLink, textImage) {
	thisLink.imgToChange = textImage;
	thisLink.onmouseout = function() {
		this.imgToChange.src = this.outImage.src;
	}
	thisLink.onmouseover = function() {
		this.imgToChange.src = this.overImage.src;
	}

	thisLink.outImage = new Image();
	thisLink.outImage.src = textImage.src;

	thisLink.overImage = new Image();
	thisLink.overImage.src = '../images/' + thisLink.id + 'Text.gif';
}
*/
/*
// 4-7 脚本1
window.onload = function() {
	oLink = document.links;
	for(var i = 0; i < oLink.length; i++) {
		var linkObj = oLink[i];
		if(linkObj) {
			var imageObj = document.getElementById(linkObj.className);
			if(imageObj) {
				setupRollover(linkObj, imageObj);
			}
		}
	}
}
function setupRollover(thisLink, thisImage) {
	thisLink.imgToChange = new Array;
	thisLink.outImage = new Array;
	thisLink.overImage = new Array;

	thisLink.imgToChange[0] = thisImage;
	thisLink.onmouseout = rollOut;
	thisLink.onmouseover = rollOver;

	thisLink.outImage[0] = new Image();
	thisLink.outImage[0].src = thisImage.src;

	thisLink.overImage[0] = new Image();
	thisLink.overImage[0].src = "../images/" + thisLink.id + "Text.gif";

	var rolloverObj = document.getElementById(thisLink.id + "Img");
	if(rolloverObj) {
		thisLink.imgToChange[1] = rolloverObj;

		thisLink.outImage[1] = new Image();
		thisLink.outImage[1].src = rolloverObj.src;

		thisLink.overImage[1] = new Image();
		thisLink.overImage[1].src = "../images/" + thisLink.id + "_on.gif";
	}

	function rollOut() {
		for(var i = 0; i < this.imgToChange.length; i++) {
			this.imgToChange[i].src = this.outImage[i].src;
		}
	}

	function rollOver() {
		for(var i = 0; i < this.imgToChange.length; i++) {
			this.imgToChange[i].src = this.overImage[i].src;
		}
	}
}
*/

// 4-7脚本2
window.onload = function() {
	if(document.getElementById) {
		setupRollover();
	}
	else {
		alert('Your browser don\'t support this script.');
	}
}
function setupRollover() {
	var oCdiv = document.getElementById("captionDiv");
	var oIdiv = document.getElementById("inventionDiv");
	var oImgShow = oCdiv.getElementsByTagName("img")[1];
	var oLink = oIdiv.getElementsByTagName("a");

	var currentSrc = oImgShow.src;

	for(var i = 0; i < oLink.length; i++) {
		oLink[i].onmouseover = function(){
			oImgShow.src = "../images/" + this.id + "Text.gif";
			this.getElementsByTagName("img")[0].src = "../images/" + this.id + "_on.gif";
		}

		oLink[i].onmouseout = function() {
			oImgShow.src = currentSrc;
			this.getElementsByTagName("img")[0].src = "../images/" + this.id + ".gif";
		}
	}
}