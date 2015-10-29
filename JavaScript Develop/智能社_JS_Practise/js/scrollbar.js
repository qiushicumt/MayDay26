// JavaScript source code
//  脚本4 滚动条改变文本框内容显示
window.onload = function () {
    var oParent = document.getElementById("div1");
    var oDiv = document.getElementById("div2");
    var oDiv5 = document.getElementById("div5");
    var oDiv6 = document.getElementById("div6");
    oDiv.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv.offsetLeft;
        var posY = oEvent.clientY - oDiv.offsetTop;

        document.onmousemove = function (ev) {
            var oEvent = ev || event;
            oDiv.style.left = (oEvent.clientX - posX) + "px";
            oDiv.style.top = 0;
            if (oDiv.offsetLeft < 0) {
                oDiv.style.left = 0;
            }
            else if (oDiv.offsetLeft > (oParent.offsetWidth - oDiv.offsetWidth)) {
                oDiv.style.left = oParent.offsetWidth - oDiv.offsetWidth + "px";
            }            
            var scale = oDiv.offsetLeft / (oParent.offsetWidth - oDiv.offsetWidth);
            document.title = scale;
            oDiv6.style.top = - scale * (oDiv6.offsetHeight - oDiv5.offsetHeight) + "px";
        }
        document.onmouseup = function () {
            document.onmousemove = null;
            document.onmouseup = null;
        }
        return false;
    }
}
/*
//  脚本3 滚动条改变div透明度
window.onload = function () {
    var oParent = document.getElementById("div1");
    var oDiv = document.getElementById("div2");
    var oDiv4 = document.getElementById("div4");
    oDiv.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv.offsetLeft;
        var posY = oEvent.clientY - oDiv.offsetTop;

        document.onmousemove = function (ev) {
            var oEvent = ev || event;
            oDiv.style.left = (oEvent.clientX - posX) + "px";
            oDiv.style.top = 0;

            if (oDiv.offsetLeft < 0) {
                oDiv.style.left = 0;
            }
            else if (oDiv.offsetLeft > (oParent.offsetWidth - oDiv.offsetWidth)) {
                oDiv.style.left = oParent.offsetWidth - oDiv.offsetWidth + "px";
            }
            document.title = oDiv.offsetLeft / (oParent.offsetWidth - oDiv.offsetWidth);
            oDiv4.style.filter = "alpha(opacity=" + (oDiv.offsetLeft / (oParent.offsetWidth - oDiv.offsetWidth) * 100) + ")";
            oDiv4.style.opacity = oDiv.offsetLeft / (oParent.offsetWidth - oDiv.offsetWidth);
        }

        document.onmouseup = function () {
            document.onmousemove = null;
            document.onmouseup = null;
        }
        return false;
    }   
}
//  脚本2 滚动条放大缩小div
window.onload = function () {
    var oParent = document.getElementById("div1");
    var oDiv = document.getElementById("div2");
    var oDiv3 = document.getElementById("div3");
    oDiv.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv.offsetLeft;
        var posY = oEvent.clientY - oDiv.offsetTop;

        document.onmousemove = function (ev) {
            var oEvent = ev || event;
            oDiv.style.left = (oEvent.clientX - posX) + "px";
            oDiv.style.top = 0;

            if (oDiv.offsetLeft < 0) {
                oDiv.style.left = 0;
            }
            else if (oDiv.offsetLeft > (oParent.offsetWidth - oDiv.offsetWidth)) {
                oDiv.style.left = oParent.offsetWidth - oDiv.offsetWidth + "px";
            }
            document.title = oDiv.offsetLeft / (oParent.offsetWidth - oDiv.offsetWidth);
            oDiv3.style.height = oDiv3.style.width = oDiv.offsetLeft / (oParent.offsetWidth - oDiv.offsetWidth) * 200 + "px";             
        }

        document.onmouseup = function () {
            document.onmousemove = null;
            document.onmouseup = null;
        }
    }
}
//  脚本1 基本的滚动条
window.onload = function () {
    var oParent = document.getElementById("div1");
    var oDiv = document.getElementById("div2");
    oDiv.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv.offsetLeft;
        var posY = oEvent.clientY - oDiv.offsetTop;

        document.onmousemove = function (ev) {
            var oEvent = ev || event;
            oDiv.style.left = (oEvent.clientX - posX) + "px";
            oDiv.style.top = 0;

            if (oDiv.offsetLeft < 0) {
                oDiv.style.left = 0;
            }
            else if (oDiv.offsetLeft > (oParent.offsetWidth - oDiv.offsetWidth)) {
                oDiv.style.left = oParent.offsetWidth - oDiv.offsetWidth + "px";
            }            
        }

        oDiv.onmouseup = function () {
            document.onmousemove = null;
            oDiv.onmouseup = null;
        }
    }
}
*/