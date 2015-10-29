// JavaScript source code
window.onload = function () {
    var oDiv = document.getElementById("play");
    var oOl = oDiv.getElementsByTagName("ol")[0];
    var oLi = oOl.getElementsByTagName("li");
    var oUl = oDiv.getElementsByTagName("ul")[0];
    var uLi = oUl.getElementsByTagName("li");
    var now = 0;

    for (var i = 0; i < oLi.length; i++) {
        oLi[i].index = i;
        oLi[i].onclick = function () {
            if (now == oLi.length) { now = 0; }
            now = this.index;
            tab();
        }
    }

    function tab1() {
        now++;
        if (now == oLi.length) { now = 0; }
        tab();
    }

    var timer = setInterval(tab1, 2500);
    oDiv.onmouseover = function () {
        clearInterval(timer);
    }
    oDiv.onmouseout = function () {
        timer = setInterval(tab1, 2500);
    }

    function tab() {
        for (var n = 0; n < oLi.length; n++) {
            oLi[n].className = "";
        }
        oLi[now].className = "active";
        moveFunc(oUl, { top: -now * uLi[0].offsetHeight, });
        
    }
}