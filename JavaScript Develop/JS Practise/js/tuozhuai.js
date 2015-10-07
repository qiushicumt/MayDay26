// JavaScript source code

//  脚本5 磁性吸附，子级div在被拖动到靠近父级div边缘的时候，可以被吸附直接停靠在父级边缘
window.onload = function () {
    var oDiv = document.getElementById("wrappage");
    var oDiv1 = document.getElementById("div1");
    oDiv.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv1.offsetLeft;
        var posY = oEvent.clientY - oDiv1.offsetTop;

        //  此处使oDiv绑定onmousemove和onmouseup事件，会出现当鼠标拖动过快脱离div时导致div不跟随鼠标移动的Bug
        //  解决此问题可以使用document来绑定onmouseover和onmouseup事件
        oDiv1.onmousemove = function (ev) {
            var oEvent = ev || event;

            oDiv1.style.left = oEvent.clientX - posX + "px";
            oDiv1.style.top = oEvent.clientY - posY + "px";
            if (oDiv1.offsetLeft < 50) {
                oDiv1.style.left = 0;
            }
            else if (oDiv1.offsetLeft > oDiv.offsetWidth - oDiv1.offsetWidth -50) {
                oDiv1.style.left = oDiv.offsetWidth - oDiv1.offsetWidth + "px";
            }
            if (oDiv1.offsetTop < 50) {
                oDiv1.style.top = 0;
            }
            else if (oDiv1.offsetTop > oDiv.offsetHeight - oDiv1.offsetHeight-50) {
                oDiv1.style.top = oDiv.offsetHeight - oDiv1.offsetHeight + "px";
            }
        }
        oDiv1.onmouseup = function () {
            oDiv1.onmousemove = null;
            oDiv1.onmouseup = null;
        }
        return false;
    }
}
/*
//  脚本4 不能拖出父级对象的div
window.onload = function () {
    var oDiv = document.getElementById("wrappage");
    var oDiv1 = document.getElementById("div1");
    oDiv.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv1.offsetLeft;
        var posY = oEvent.clientY - oDiv1.offsetTop;

        //  此处使oDiv绑定onmousemove和onmouseup事件，会出现当鼠标拖动过快脱离div时导致div不跟随鼠标移动的Bug
        //  解决此问题可以使用document来绑定onmouseover和onmouseup事件
        oDiv1.onmousemove = function (ev) {
            var oEvent = ev || event;
            
            oDiv1.style.left = oEvent.clientX - posX + "px";
            oDiv1.style.top = oEvent.clientY - posY + "px";
            if (oDiv1.offsetLeft < 0) {
                oDiv1.style.left = 0;
            }
            else if (oDiv1.offsetLeft > oDiv.offsetWidth - oDiv1.offsetWidth) {
                oDiv1.style.left = oDiv.offsetWidth - oDiv1.offsetWidth + "px";
            }
            if (oDiv1.offsetTop < 0) {
                oDiv1.style.top = 0;
            }
            else if (oDiv1.offsetTop > oDiv.offsetHeight - oDiv1.offsetHeight) {
                oDiv1.style.top = oDiv.offsetHeight - oDiv1.offsetHeight + "px";
            }
        }
        oDiv1.onmouseup = function () {      
            oDiv1.onmousemove = null;
            oDiv1.onmouseup = null;
        }
        return false;
    }
}
//  脚本3 拖拽的最终版本，控制边缘位置
function getPos(iEvent) {
    var scrollTop = document.documentElement.scrollTop || document.body.scrollTop;
    var scrollLeft = document.documentElement.scrollLeft || document.body.scrollLeft;
    var posX = iEvent.clientX + scrollLeft;
    var posY = iEvent.clientY + scrollTop;
    return { x: posX, y: posY };
}

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