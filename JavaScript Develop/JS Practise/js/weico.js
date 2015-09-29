// JavaScript source code
//  新浪微博效果，主要运用链式运动的原理，先把li加入到ul中，然后将li的height通过运动变大之后将opacity属性运动显示
window.onload = function () {
    var oDiv = document.getElementById("wrappage");
    var oTextarea = document.getElementById("textarea1");
    var oBtn = document.getElementById("btn1");
    var oDiv1 = document.getElementById("div1");
    var oUl = oDiv1.getElementsByTagName("ul")[0];

    oBtn.onclick = function () {
        var oLi = document.createElement("li");       
        oLi.innerHTML = oTextarea.value;

        //  此处对ul的子节点进行操作，使用ul.children的属性，children返回的也是一个NodeList对象，children列表只包含Element对象，而且不存在兼容性问题
        //  childNodes对象则存在兼容性问题，在IE中包含空白节点
        if (oUl.children.length > 0) {
            oUl.insertBefore(oLi, oUl.children[0]);
        }
        else {
            oUl.appendChild(oLi);
        }
        var iHeight = oLi.offsetHeight;
        oLi.style.height = 0 + "px";
        moveFunc(oLi, { height: iHeight }, function () {
            moveFunc(oLi, { opacity: 100 });
        });

        oTextarea.value = "";
    }
}

/*
window.onload = function () {
    var oDiv = document.getElementById("wrappage");
    var oTextarea = document.getElementById("textarea1");
    var oBtn = document.getElementById("btn1");
    var oDiv1 = document.getElementById("div1");
    var oUl = oDiv1.getElementsByTagName("ul")[0];

    oBtn.onclick = function () {
        var oLi = document.createElement("li");
        oLi.innerHTML = oTextarea.value;
        //  oUl.appendChild(oLi);
        oUl.insertBefore(oLi, oUl.firstElementChild);
        var iHeight = oLi.offsetHeight;
        oLi.style.height = 0;
        moveFunc(oLi, { height: iHeight }, function () {
            moveFunc(oLi, { opacity: 100 });
        });
        oTextarea.value = "";
    }
}
*/
