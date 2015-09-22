/**
 * Created by MayDay26 on 2015/9/22.
 */
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
