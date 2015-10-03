// JavaScript source code
function getPos(iEvent) {
    var scrollTop = document.documentElement.scrollTop || document.body.scrollTop;
    var scrollLeft = document.documentElement.scrollLeft || document.body.scrollLeft;
    var posX = iEvent.clientX + scrollLeft;
    var posY = iEvent.clientY + scrollTop;
    return { x: posX, y: posY };
}

//  脚本3 拖拽的最终版本，控制边缘位置
window.onload = function () {
    var oDiv = document.getElementById("div1");
    document.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = getPos(oEvent).x - oDiv.offsetLeft;
        var posY = getPos(oEvent).y - oDiv.offsetTop;
        document.onmousemove = function (ev) {
            var oEvent = ev || event;
            oDiv.style.left = getPos(oEvent).x - posX + "px";
            oDiv.style.top = getPos(oEvent).y - posY + "px";
            if (oDiv.offsetLeft < 0) {
                oDiv.style.left = 0;
            }
            else if (oDiv.offsetLeft > (document.documentElement.clientWidth - oDiv.offsetWidth)) {
                oDiv.style.left = document.documentElement.clientWidth - oDiv.offsetWidth + "px";
            }
            if (oDiv.offsetTop < 0) {
                oDiv.style.top = 0;
            }
            else if (oDiv.offsetTop > (document.documentElement.clientHeight - oDiv.offsetHeight)) {
                oDiv.style.top = document.documentElement.clientHeight - oDiv.offsetHeight + "px";
            }
        }
        document.onmouseup = function () {
            document.onmousemove = null;
            document.onmouseup = null;
        }
        return false;
    }
}

/*
//  脚本2 标准的拖拽
//  mousedown事件为鼠标按钮被点击发生的动作，mouseup事件为鼠标按钮被抬起发生的动作
document.onmousedown = function (ev) {
    var oEvent = ev || event;
    var oDiv = document.getElementById("div1");
    var posX = getPos(oEvent).x - oDiv.offsetLeft;
    var posY = getPos(oEvent).y - oDiv.offsetTop;

    document.onmousemove = function (ev) {
        var oEvent = ev || event;
        oDiv.style.left = getPos(oEvent).x - posX + "px";
        oDiv.style.top = getPos(oEvent).y - posY + "px";
    }

    document.onmouseup = function () {
        document.onmousemove = null;
    }

    return false;   //  return false在此处用于阻止firefox自带的bug
}

//  脚本1 自写的拖拽
document.onmousedown = function (ev) {
    var oDiv = document.getElementById("div1");
    var oEvent = ev || event;
    document.onmousemove = function (ev) {
        var oEvent = ev || event;
        oDiv.style.left = (getPos(oEvent).x - 15) + "px";
        oDiv.style.top = (getPos(oEvent).y - 8) + "px";
    }
    document.onmouseup = function () {
        document.onmousemove = null;
    }
}
*/