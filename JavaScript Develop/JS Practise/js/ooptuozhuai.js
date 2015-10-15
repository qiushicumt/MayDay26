// JavaScript source code

//  脚本2 面向对象拖拽，无范围限制

function TuoZhuai(id) {
    this.oDiv1 = document.getElementById(id);
    this.posX = 0;
    this.posY = 0;
    var _this = this;
    this.oDiv1.onmousedown = function (ev) {
        _this.fnDown(ev);
        return false;
    }
}
TuoZhuai.prototype.fnDown = function (ev) {    
    var oEvent = ev || event;
    var _this = this;
    this.posX = oEvent.clientX - this.oDiv1.offsetLeft;
    this.posY = oEvent.clientY - this.oDiv1.offsetTop;
    document.onmousemove = function (ev) {
        _this.fnMove(ev);
    }
    document.onmouseup = function () {
        _this.fnUp();
    }
}
TuoZhuai.prototype.fnMove = function(ev) {
    var oEvent = ev || event;
    this.oDiv1.style.left = oEvent.clientX - this.posX + 'px';
    this.oDiv1.style.top = oEvent.clientY - this.posY + 'px';
}
TuoZhuai.prototype.fnUp = function() {
    document.onmousemove = null;
    document.onmouseup = null;
}
/*

//  脚本1 面向过程的拖拽
window.onload = function () {
    var oDiv = document.getElementById('wrappage');
    var oDiv1 = oDiv.getElementsByTagName('div')[0];
    oDiv1.onmousedown = function (ev) {
        var oEvent = ev || event;
        var posX = oEvent.clientX - oDiv1.offsetLeft;
        var posY = oEvent.clientY - oDiv1.offsetTop;
        document.onmousemove = function (ev) {
            var oEvent = ev || event;
            oDiv1.style.left = oEvent.clientX - posX + 'px';
            oDiv1.style.top = oEvent.clientY - posY + 'px';
        }
        document.onmouseup = function () {
            document.onmousemove = null;
            document.onmouseup = null;
        }
        return false;
    }
}
*/