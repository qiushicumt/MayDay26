/**
 * Created by MayDay26 on 2015/9/22.
 *
 *
 */
// 脚本3
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
    var oBigDiv = document.getElementById("bigImage");
    var oSmallDiv = document.getElementById("smallImage");

    var prevButton = getClass(oBigDiv, "prev")[0];
    var nextButton = getClass(oBigDiv, "next")[0];
    var oMarkLeft = getClass(oBigDiv, "mark_left")[0];
    var oMarkRight = getClass(oBigDiv, "mark_right")[0];

    var oUlBig = oBigDiv.getElementsByTagName("ul")[0];
    var oLiBig = oUlBig.getElementsByTagName("li");
    var oUlSmall = oSmallDiv.getElementsByTagName("ul")[0];
    var oLiSmall = oUlSmall.getElementsByTagName("li");

    var now = 0;            //  用now来进行标记
    var nowZIndex = 2;

    //oUlSmall.style.width = oLiSmall.length * oLiSmall[0].offsetWidth;
    oUlSmall.style.width = 1200 + "px";
    //alert(oUlSmall.offsetWidth);

    //  左右按钮显示
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

    //  点击小图使大图进行相应切换
    for (var i = 0; i < oLiSmall.length; i++) {
        oLiSmall[i].index = i;
        oLiSmall[i].onclick = function () {
            if (this.index == now) { return; }
            now = this.index;
            oLiBig[now].style.zIndex = nowZIndex++;

            for (var j = 0; j < oLiSmall.length; j++) {
                moveFunc(oLiSmall[j], "opacity", 50);
            }
            moveFunc(this, "opacity", 100);
            oLiBig[now].style.height = 0;
            moveFunc(oLiBig[now], "height", 400);
        }
        //  鼠标悬停小图来改变小图的透明度
        oLiSmall[i].onmouseover = function () {
            moveFunc(this, "opacity", 100);
        }
        oLiSmall[i].onmouseout = function () {
            if (this.index != now) {
                moveFunc(this, "opacity", 50);
            }
        }
    }
    prevButton.onclick = function () {
        now--;
        if (now == -1) { now = oLiBig.length - 1; }
        oLiBig[now].style.zIndex = nowZIndex++;
        oLiBig[now].style.height = 0;
        moveFunc(oLiBig[now], "height", 400);
        if (now == 0) {
        }
        else if (now == oLiBig.length - 1) {
            moveFunc(oUlSmall, "left", -585);
        }
        else {
            moveFunc(oUlSmall, "left", -((now - 1) * 195));
        }
        for (var i = 0; i < oLiSmall.length; i++) {
            moveFunc(oLiSmall[i], "opacity", 50);
        }
        moveFunc(oLiSmall[now], "opacity", 100);
    }
    nextButton.onclick = function () {
        now++;
        if (now == oLiBig.length) { now = 0; }
        oLiBig[now].style.zIndex = nowZIndex++;
        oLiBig[now].style.height = 0;
        moveFunc(oLiBig[now], "height", 400);
        if (now == 0) {
            moveFunc(oUlSmall, "left", 0);
        }
        else if (now == oLiBig.length - 1) {
        }
        else {
            moveFunc(oUlSmall, "left", -((now - 1) * 195));
        }
        for (var i = 0; i < oLiSmall.length; i++) {
            moveFunc(oLiSmall[i], "opacity", 50);
        }
        moveFunc(oLiSmall[now], "opacity", 100);
    }
    var timer = setInterval(nextButton.onclick, 3000);
    oBigDiv.onmousemove = function () { clearInterval(timer); }
    oBigDiv.onmouseout = function () { timer = setInterval(nextButton.onclick, 3000); }
}

/*
 *脚本2
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
 */

/*
 * 脚本1
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

