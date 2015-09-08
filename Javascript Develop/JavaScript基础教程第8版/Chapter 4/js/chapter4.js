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

// 4-8 脚本1
window.onload = function() {
	var thisImageSrc = new Array("../images/reading1.gif", "../images/reading2.gif", "../images/reading3.gif");
	var oImg = document.getElementById("adBanner");
	var i = 0;
	function changeImage() {		
		if(i < thisImageSrc.length) {
			oImg.src = thisImageSrc[i];
			i++;
		}
		else {
			i = 0;
		}		
	}
	var timer = setInterval(changeImage, 2000);
	oImg.onmouseover = function() {
		clearInterval(timer);
	}
	oImg.onmouseout = function() {
		timer = setInterval(changeImage, 2000);
	}
}

// 4-8 脚本2
window.onload = rotateInit;
var rotateNum = 0;
function rotateInit() {
	var oImg = document.getElementById("adBanner");
	var imageSrc = new Array("../images/reading1.gif", "../images/reading2.gif", "../images/reading3.gif");
	if(rotateNum < imageSrc.length) {
		oImg.src = imageSrc[rotateNum];
		rotateNum++;
		console.log(oImg.src);
	}
	else {
		rotateNum = 0;
	}
	setTimeout(rotateInit, 2000);
}

// 4-8 脚本3 
var imgNum = 0;		// imgNum声明为全局变量
window.onload = function() {
	var oImg = document.getElementById("adBanner");
	var imageSrc = new Array("../images/reading1.gif", "../images/reading2.gif", "../images/reading3.gif");
	function rotateImg() {		
		if(imgNum == imageSrc.length) 
			imgNum = 0;
		oImg.src = imageSrc[imgNum];
		imgNum++;
	}
	var timer = setInterval(rotateImg, 2000);
	oImg.onmouseover = function() {
		clearInterval(timer);
	}
	oImg.onmouseout = function() {
		timer = setInterval(rotateImg, 2000);
	}
}

// 4-9 脚本1
var imgNum = 0;
window.onload = function() {
	if(document.getElementById("adBanner").parentNode.tagName == "A")
		document.getElementById("adBanner").parentNode.onclick = changeLink;
	rotateImage();
}

function changeLink() {
	var newUrl = new Array("baidu.com", "qq.com", "163.com");
	document.location.href = "http://www." + newUrl[imgNum];
	console.log(ewUrl[imgNum] + " " + imgNum);
	return false; 
}

function rotateImage() {
	var imageSrc = new Array("../images/banner1.gif", "../images/banner2.gif", "../images/banner3.gif");
	var oImg = document.getElementById("adBanner");	
	function rotate() {
		if(imgNum == imageSrc.length) {
			imgNum = 0;
		}
		oImg.src = imageSrc[imgNum];
		imgNum++;
	}
	var timer = setInterval(rotate, 2000);
}

// 4-9 脚本2
var thisAd = 0;
window.onload = initAll;
function initAll() {
	if(document.getElementById("adBanner").parentNode.tagName == "A")
		document.getElementById("adBanner").parentNode.onclick = newLink;
	rotate();
}
function newLink() {
	var newUrl = new Array("www.baidu.com", "www.qq.com", "www.163.com");
	document.location.href = "http://" + newUrl[thisAd];
	return false;
}
function rotate() {
	var oImg = document.getElementById("adBanner");
	var bannerImg = new Array("../images/banner1.gif", "../images/banner2.gif", "../images/banner3.gif");
	function startRotate() {
		thisAd++;
		if(thisAd == bannerImg.length)
			thisAd = 0;
		oImg.src = bannerImg[thisAd];
	}
	var timer = setInterval(startRotate, 2500);
	oImg.onmouseover = function () {
		clearInterval(timer);
	}
	oImg.onmouseout = function() {
		timer = setInterval(startRotate, 2500);
	}
}

// 4-10 脚本
window.onload = initAll;
function initAll() {
	var oImg = document.getElementById("myPicture");
	var slideImg = new Array("../images/robot1.jpg", "../images/robot2.jpg", "../images/robot3.jpg");
	var prevA = document.getElementById("prevLink");
	var nextA = document.getElementById("nextLink");
	var thisImgNum = 0;

	prevA.onclick = function() {
		thisImgNum--;
		if(thisImgNum < 0)
			thisImgNum = slideImg.length - 1;
		oImg.src = slideImg[thisImgNum];
	}
	nextA.onclick = function() {
		thisImgNum++;
		if(thisImgNum == slideImg.length)
			thisImgNum = 0;
		oImg.src = slideImg[thisImgNum];

	}
}

// 4-11 脚本
window.onload = function() {
	var animalImage = new Array("../images/bear.jpg", "../images/lion.jpg" ,"../images/tiger.jpg");
	var oImg = document.getElementById("animalImg");
	var oButton = document.getElementById("changeImg");
	
	oButton.onclick = function() {
		var randomNum = Math.floor(Math.random() * animalImage.length);
		oImg.src = animalImage[randomNum];
	}
}

// 4-12 脚本
window.onload = initAll;
imgArray = new Array("../images/reading1.gif", "../images/reading2.gif", "../images/reading3.gif");
var randomNum = 0;
function initAll() {	
	oImg = document.getElementById("myPicture");
	randomNum = Math.floor(Math.random() * imgArray.length);
	oImg.src = imgArray[randomNum];
	rotate();
}
function rotate() {
	randomNum++;
	if(randomNum == imgArray.length)
		randomNum = 0;
	oImg.src = imgArray[randomNum];
	setTimeout(rotate, 2500);
}
*/