/**
 * Created by MayDay26 on 2015/9/22.
 */
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
