//  �ű�4 ���սű�
function getClass(oParent, sClass) { }

/*
// �ű�3
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

    //  ���Ұ�ť��ʾ
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

// �ű�2
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

 //  ���Сͼ��ʹ��Ӧ�Ĵ�ͼ�����л�
     for(var i = 0; i < oSmallLi.length; i++) {
         oSmallLi[i].index = i;
         oSmallLi[i].onclick = function() {
             oBigLi[this.index].style.zIndex = nowZIndex++;
             oBigLi[this.index].style.height = 0;
             moveFunc(oBigLi[this.index], 'height', 400);
         }
     }
 }

//  �ű�1
 function getClass(oParent, oClass) {
     var oEle = oParent.getElementsByTagName("*");       //  ʹ��ͨ�����*��������ȡ��ǩ�����е�Ԫ��
     var oResult = [];                                   //  �����������ڴ���������ķ���ClassName��Ԫ�ر�ǩ
     for(var i = 0; i < oEle.length; i++) {
         if(oEle[i].className == oClass) {
            oResult.push(oEle[i]);                      //  ��Ԫ��push��������
         }
     }
     return oResult;                                     //  ������������
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

 //  ���Ұ�ť�ĵ��뵭��
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