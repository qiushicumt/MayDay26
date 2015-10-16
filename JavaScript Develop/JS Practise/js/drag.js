// JavaScript source code

//  脚本2 面向对象拖拽
//  this一般引用实施调用的对象
function Drag(id) {
    this.oDiv = document.getElementById(id);

    this.posX = 0;
    this.posY = 0;
    var _this = this;
    this.oDiv.onmousedown = function (ev) {       
        _this.fnDown(ev);
        return false;
    }
}
Drag.prototype.fnDown = function (ev) {
    var oEvent = ev || event;
    var _this = this;

    this.posX = oEvent.clientX - this.oDiv.offsetLeft;
    this.posY = oEvent.clientY - this.oDiv.offsetTop;
    document.onmousemove = function (ev) {
        _this.fnMove(ev);
    }
    document.onmouseup = function () {
        _this.fnUp();
    }
}
Drag.prototype.fnMove = function (ev) {
    var oEvent = ev || event;
    this.oDiv.style.left = oEvent.clientX - this.posX + 'px';
    this.oDiv.style.top = oEvent.clientY - this.posY + 'px';
}
Drag.prototype.fnUp = function () {
    document.onmousemove = null;
    document.onmouseup = null;
}
/*  
//  脚本1 面向过程拖拽
window.onload = function () {
    var oDiv = document.getElementById("div1");
    oDiv.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv.offsetLeft;
        var posY = oEvent.clientY - oDiv.offsetTop;

        document.onmousemove = function (ev) {
            var oEvent = ev || event;
            oDiv.style.left = oEvent.clientX - posX + 'px';
            oDiv.style.top = oEvent.clientY - posY + 'px';

        }
        document.onmouseup = function () {
            document.onmousemove = null;
            document.onmouseup = null;
        }

        return false;
    }
}
*/