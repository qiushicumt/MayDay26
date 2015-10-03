// JavaScript source code

//  脚本2 右键菜单屏蔽，右键弹出自定义div
function getPos(iEvent) {       //  获取鼠标位置
    var scrollTop = document.documentElement.scrollTop || document.body.scrollTop;
    var scrollLeft = document.documentElement.scrollLeft || document.body.scrollLeft;
    var posX = screenLeft + iEvent.clientX;
    var posY = scrollTop + iEvent.clientY;
    return { x: posX, y: posY };
}
//  oncontextmenu方法为右键菜单方法，return false可以阻止浏览器默认右键菜单的弹出
document.oncontextmenu = function (ev) {
    var oEvent = ev || event;
    var oDiv = document.getElementById("div1");
    oDiv.style.display = "block";
    oDiv.style.left = getPos(oEvent).x + "px";
    oDiv.style.top = getPos(oEvent).y + "px";
    
    return false;
}
document.onclick = function () {
    var oDiv = document.getElementById("div1");
    oDiv.style.display = "none";
}

/*
//  脚本1 阻值页面默认的右键菜单行为
document.oncontextmenu = function (ev) {
    return false;
}
*/