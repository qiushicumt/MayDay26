window.onload = function () {
    var oDiv = document.getElementById("div1");
    oDiv.onmouseover = function () {
        moveFunc(oDiv, {width:300, height:300, opacity:100});   //  传入json数据后，在定时器每一次运行的过程中，会对json中的每一对键值对进行操作一次
    }
    oDiv.onmouseout = function () {
        moveFunc(oDiv, {width:120, height:120, opacity:30});
    }
}

/*
//  脚本2 土豆网右下角按钮弹出菜单
window.onload = function () {
    var znsBottom = document.getElementById("zns_bottom");
    var showButton = document.getElementById("but");
    var znsBox = document.getElementById("zns_box");
    var closeButton = document.getElementById("btn_close");

    showButton.onclick = function () {
        moveFunc(znsBottom, "right", 0, function () {
            znsBox.style.display = "block";
            moveFunc(znsBox, "bottom", 0);
        });
    }
    closeButton.onclick = function () {
        moveFunc(znsBox, "bottom", -315, function () {
            znsBox.style.display = "none";
            moveFunc(znsBottom, "right", -165);
        });
    }
}

//  脚本1 链式运动基础脚本
window.onload = function () {
    var oDiv = document.getElementById("div1");
    oDiv.onmouseover = function () {
        moveFunc(this, "width", 300, function () {
            moveFunc(oDiv, "height", 300, function () {
                moveFunc(oDiv, "opacity", 100);
            });
        });
    }
    oDiv.onmouseout = function () {
        moveFunc(this, "opacity", 30, function () {
            moveFunc(oDiv, "height", 100, function () {
                moveFunc(oDiv, "width", 100);
            });
        });
    }
}
*/