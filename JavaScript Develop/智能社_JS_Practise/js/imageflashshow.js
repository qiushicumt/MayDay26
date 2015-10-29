//  脚本4 最终脚本
function getClass(oParent, sClass) {
    var oEle = oParent.getElementsByTagName("*");
    var oResult = new Array();
    for (var i = 0; i < oEle.length; i++) {
        if (oEle[i].className == sClass) {
            oResult.push(oEle[i]);
        }
    }
    return oResult;
}

window.onload = initAll;
function initAll() {
    var oDiv = document.getElementById("wrappage");
    var oBigImage = document.getElementById("bigImage");
    var oSmallImage = document.getElementById("smallImage");

    var prevButton = getClass(oBigImage, "prev")[0];
    var nextButton = getClass(oBigImage, "next")[0];
    var oMarkLeft = getClass(oBigImage, "mark_left")[0];
    var oMarkRight = getClass(oBigImage, "mark_right")[0];
    var oText = getClass(oBigImage, "text")[0];
    var oLength = getClass(oBigImage, "length")[0];

    var oUlBig = oBigImage.getElementsByTagName("ul")[0];
    var oLiBig = oUlBig.getElementsByTagName("li");
    var oUlSmall = oSmallImage.getElementsByTagName("ul")[0];
    var oLiSmall = oUlSmall.getElementsByTagName("li");

    var nowZIndex = 2;
    var now = 0;
    var textArray = ["图片1", "图片2", "图片3", "图片4", "图片5", "图片6"];

    oUlSmall.style.width = oLiSmall[0].offsetWidth * oLiSmall.length + "px";    //  将小图的ul的width设置为所有小图的offsetWidth之和

    //  初始化显示的文字以及图片数量
    oText.innerHTML = textArray[now];
    oLength.innerHTML = (now + 1) + "/" + oLiBig.length;
    
    //  左右按钮显示隐藏
    prevButton.onmouseover = oMarkLeft.onmouseover = function () {
        moveFunc(prevButton, "opacity", 100);
    }
    prevButton.onmouseout = oMarkLeft.onmouseout = function () {
        moveFunc(prevButton, "opacity", 0);
    }
    nextButton.onmouseover = oMarkRight.onmouseover = function () {
        moveFunc(nextButton, "opacity", 100);
    }
    nextButton.onmouseout = oMarkRight.onmouseout = function () {
        moveFunc(nextButton, "opacity", 0);
    }
  
    //  点击小图切换大图效果和鼠标悬停小图淡入淡出效果
    for (var i = 0; i < oLiSmall.length; i++) {
        oLiSmall[i].index = i;
        oLiSmall[i].onclick = function () {
            if (this.index == now) { return; }
            now = this.index;       //  now变量用于标记当前
            tab();
        }
        oLiSmall[i].onmouseover = function () {
            moveFunc(this, "opacity", 100);
        }
        oLiSmall[i].onmouseout = function () {
            //  当smallImage的li的index=now时，表示当前大图正在显示这个小图，所以，index！=now的时候执行改变为半透明的操作
            if (this.index != now) {
                moveFunc(this, "opacity", 50);
            }
        }
    }
    //  左右按钮点击进行图片切换
    prevButton.onclick = function () {
        now--;
        if (now == -1) { now = oLiBig.length - 1; }
        tab();
    }

    nextButton.onclick = function () {
        now++;
        if (now == oLiBig.length) { now = 0; }
        tab();
    }

    var timer = setInterval(nextButton.onclick, 3000);
    oBigImage.onmouseover = function () {
        clearInterval(timer);
    }
    oBigImage.onmouseout = function () {
        timer = setInterval(nextButton.onclick, 3000);
    }

    function tab() {
        //  通过将大图的z-index值变大，使大图显示出来
        oLiBig[now].style.zIndex = nowZIndex++;

        //  设置显示的文字以及图片数量
        oText.innerHTML = textArray[now];
        oLength.innerHTML = (now + 1) + "/" + oLiBig.length;

        //  通过改变小图的ul的left值，使小图跟随大图的切换进行运动
        if (now == 0) {
            moveFunc(oUlSmall, "left", 0);
        }
        else if (now == oLiBig.length - 1) {
            moveFunc(oUlSmall, "left", -(now - 2) * oLiSmall[0].offsetWidth);
        }
        else {
            moveFunc(oUlSmall, "left", -(now - 1) * oLiSmall[0].offsetWidth);
        }
        //  先将所有小图的透明度设置为半透明，然后再将当前正在显示的大图对应的小图的透明度设置为不透明
        for (var j = 0; j < oLiSmall.length; j++) {
            moveFunc(oLiSmall[j], "opacity", 50);
        }
        moveFunc(oLiSmall[now], "opacity", 100);    //  错误：moveFunc(this, "opacity", 100);  //  此处不能继续使用this

        //  图片刷新产生下拉效果，先把li高度设为0，然后再调用运动函数还原高度。
        oLiBig[now].style.height = 0;
        moveFunc(oLiBig[now], "height", 400);
    }
}

/*
// 脚本3
function getClass(oParent, sClass){
    var oEle = oParent.getElementsByTagName("*");
    var oResult = new Array();
    for(var i = 0; i < oEle.length; i++) {
        if(oEle[i].className == sClass) {
            oResult.push(oEle[i]);
        }
    }
    return oResult;
}
window.onload = initAll;
function initAll() {
    var oBigDiv = document.getElementById("bigImage");
    var oSmallDiv = document.getElementById("smallImage");

    var prevButton = getClass(oBigDiv, "prev")[0];
    var nextButton = getClass(oBigDiv, "next")[0];
    var oMarkLeft = getClass(oBigDiv, "mark_left")[0];
    var oMarkRight = getClass(oBigDiv, "mark_right")[0];

    //  左右按钮显示
    prevButton.onmouseover = oMarkLeft.onmouseover = function() {
        moveFunc(prevButton, "opacity", 100);
    }
    prevButton.onmouseout = oMarkLeft.onmouseout = function() {
        moveFunc(prevButton, "opacity", 0);
    }
    nextButton.onmouseover = oMarkRight.onmouseover = function() {
        moveFunc(nextButton, "opacity", 100);
    }
    nextButton.onmouseout = oMarkRight.onmouseout = function() {
        moveFunc(nextButton, "opacity", 0);
    }
}

// 脚本2
 function getClass(oParent, sClassName) {
     var oEle = oParent.getElementsByTagName('*');
     var oResult = new Array();
     for(var i = 0; i < oEle.length; i++) {
         if(oEle[i].className == sClassName) {
            oResult.push(oEle[i]);
         }
     }
     return oResult;
 }

 window.onload = function() {
     var theDiv = document.getElementById('wrappage');
     var oDiv1 = document.getElementById("big_img");
     var oDiv2 = document.getElementById("small_img");
     var prevButton = getClass(oDiv1, 'prev')[0];
     var nextButton = getClass(oDiv1, 'next')[0];
     var oBigLeft = getClass(oDiv1, 'mark_left')[0];
     var oBigRight = getClass(oDiv1, 'mark_right')[0];

     var oBigLi = oDiv1.getElementsByTagName('li');

     var oSmallLi = oDiv2.getElementsByTagName("li");

     var nowZIndex = 2;

     prevButton.onmouseover = oBigLeft.onmouseover = function() {
        moveFunc(prevButton, 'opacity', 100);
     }
     prevButton.onmouseout = oBigLeft.onmouseout = function() {
        moveFunc(prevButton, 'opacity', 0);
     }
     nextButton.onmouseover = oBigRight.onmouseover = function() {
        moveFunc(nextButton, 'opacity', 100);
     }
     nextButton.onmouseout = oBigRight.onmouseout = function() {
        moveFunc(nextButton, 'opacity', 0);
     }

 //  点击小图，使对应的大图进行切换
     for(var i = 0; i < oSmallLi.length; i++) {
         oSmallLi[i].index = i;
         oSmallLi[i].onclick = function() {
             oBigLi[this.index].style.zIndex = nowZIndex++;
             oBigLi[this.index].style.height = 0;
             moveFunc(oBigLi[this.index], 'height', 400);
         }
     }
 }

//  脚本1
 function getClass(oParent, oClass) {
     var oEle = oParent.getElementsByTagName("*");       //  使用通配符‘*’，来获取标签下所有的元素
     var oResult = [];                                   //  声明数组用于存放搜索到的符合ClassName的元素标签
     for(var i = 0; i < oEle.length; i++) {
         if(oEle[i].className == oClass) {
            oResult.push(oEle[i]);                      //  将元素push到数组中
         }
     }
     return oResult;                                     //  返回整个数组
 }

 window.onload = function() {
     var oDiv1 = document.getElementById('mainImage');
     var oDiv2 = document.getElementById('listImage');
     var leftButton = getClass(oDiv1, 'prev')[0];
     var rightButton = getClass(oDiv1, 'next')[0];
     var oMarkLeft = getClass(oDiv1, 'mark_left')[0];
     var oMarkRight = getClass(oDiv1, 'mark_right')[0];
     var oText = getClass(oDiv1, 'text')[0];
     var oLength = getClass(oDiv1, 'length')[0];

 //  左右按钮的淡入淡出
     leftButton.onmouseover = oMarkLeft.onmouseover = function() {
        moveFunc(leftButton, 'opacity', 100);
     }
     rightButton.onmouseover = oMarkRight.onmouseover = function() {
        moveFunc(rightButton, 'opacity', 100);
     }
     leftButton.onmouseout = oMarkLeft.onmouseout = function() {
        moveFunc(leftButton, 'opacity', 0);
     }
     rightButton.onmouseout = oMarkRight.onmouseout = function() {
        moveFunc(rightButton, 'opacity', 0);
     }
 }
*/