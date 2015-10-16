// JavaScript source code

//  call方法可以用于继承父对象的属性和方法，使用方式：父对象.call(this, ...)
//  被继承的父对象调用call方法，传入的第一个参数为this，用于引用子对象，后面参数属于子对象需要的形参
function LimitDrag(id) {
    Drag.call(this, id);          
}
for (var i in Drag.prototype) {
    LimitDrag.prototype[i] = Drag.prototype[i];
}
LimitDrag.prototype.fnMove = function (ev) {
    var oEvent = ev || event;
    
    var l = oEvent.clientX - this.posX;
    var t = oEvent.clientY - this.posY;
    if (l < 0) {
        l = 0;
    }
    else if (l > document.documentElement.clientWidth - this.oDiv.offsetWidth) {
        l = document.documentElement.clientWidth - this.oDiv.offsetWidth;
    }
    if (t < 0) {
        t = 0;
    }
    else if (t > document.documentElement.clientHeight - this.oDiv.offsetHeight) {
        t = document.documentElement.clientHeight - this.oDiv.offsetHeight;
    }

    this.oDiv.style.left = l + 'px';
    this.oDiv.style.top = t + 'px';
}