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
*/
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
		var linkObj = document.links[i];
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
	thisLink.overImage.src = '../images/' + thisLink.id + '.gif';
}



