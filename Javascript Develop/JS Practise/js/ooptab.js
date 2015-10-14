/**
 * Created by mayday26 on 15-10-14.
 */

//  脚本3 面向对象的选项卡显示

window.onload = function() {
    new TabSwitch("wrappage");
}

function TabSwitch(id) {
    var oDiv = document.getElementById(id);

    this.oBtn = oDiv.getElementsByTagName("input");
    this.oDiv1 = oDiv.getElementsByTagName("div");

    for(var i = 0; i < this.oBtn.length; i++) {
        this.oBtn[i].index = i;
        this.oBtn[i].onclick = this.fnClick;
    }
}

TabSwitch.prototype.fnClick = function () {
    var _this = this;
    for(var i = 0; i < _this.oBtn.length; i++) {
        _this.oBtn[i].className = "";
        _this.oDiv1[i].style.display = "none";
    }
    _this.className = "active";
    _this.oDiv1[_this.index].style.display = "block";
}

/*
//  脚本2 面向对象的选项卡显示
//  把面向过程的方式改写为面向对象的方式要使函数当中不会出现函数嵌套

var oBtn = null;
var oDiv1  = null;
window.onload = function() {
    var oDiv = document.getElementById("wrappage");
    oBtn = oDiv.getElementsByTagName("input");
    oDiv1 = oDiv.getElementsByTagName("div");

    for(var i = 0; i < oBtn.length; i++) {
        oBtn[i].index = i;
        oBtn[i].onclick = fnTab;
    }
}
function fnTab() {
    for(var i = 0; i < oBtn.length; i++) {
        oBtn[i].className = "";
        oDiv1[i].style.display = "none";
    }
    this.className = "active";
    oDiv1[this.index].style.display = "block";
}

//  脚本1 面向过程的选项卡显示
window.onload = function() {
    var oDiv = document.getElementById("wrappage");
    var oBtn = oDiv.getElementsByTagName("input");
    var oDiv1 = oDiv.getElementsByTagName("div");

    for(var i = 0; i < oBtn.length; i++) {
        oBtn[i].index = i;
        oBtn[i].onclick = function() {
            for(var i = 0; i < oBtn.length; i++) {
                oBtn[i].className = "";
                oDiv1[i].style.display = "none";
            }
            this.className = "active";
            oDiv1[this.index].style.display = "block";
        }
    }
}
*/