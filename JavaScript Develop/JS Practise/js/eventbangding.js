// JavaScript source code

//  脚本2 解决兼容性问题的事件绑定的脚本
function addEvent(obj, iEvent, func) {
    if (obj.attachEvent) {
        obj.attachEvent("on" + iEvent, func);
    }
    else {
        obj.addEventListener(iEvent, func, false);
    }
}
window.onload = function () {
    var oBtn = document.getElementById("btn1");
    addEvent(oBtn, "click", function () {
        alert("a");
    });
    addEvent(oBtn, "click", function () {
        alert("b");
    })
}

/*
//  脚本1 事件绑定基本脚本
window.onload = function () {
    var oBtn = document.getElementById("btn1");

    //  Chrome/Firefox/IE9浏览器中使用的事件绑定的方法addEventListener();
    oBtn.addEventListener("click", function () {
        alert("a");
    }, false);
    oBtn.addEventListener("click", function () {
        alert("b");
    }, false);

    //  IE6~8浏览器中使用的事件绑定的方法attachEvent();
    oBtn.attachEvent("onclick", function () {
        alert("a");
    });
    oBtn.attachEvent("onclick", function () {
        alert("b");
    });
 
}
*/