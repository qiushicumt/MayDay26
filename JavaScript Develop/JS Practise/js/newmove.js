// JavaScript source code
function getStyle(obj, attr) {      //  返回元素属性值
    if (obj.currentStyle) {
        return obj.currentStyle[attr];      //  IE6~8中获得元素属性值
    }
    else {
        return getComputedStyle(obj, null)[attr];   //  IE9、Chrome、Firefox浏览器获取元素属性值
    }
}

//  function moveFunc(obj, attr, iTarget, newFunc) {     //  运动函数框架，此处json形参用于传入json格式的数据
function moveFunc(obj, json, newFunc) {
    clearInterval(obj.timer);               //  先将对象的上一个定时器关闭
    obj.timer = setInterval(function () {     //  设置定时器
        for (var attr in json) {
            var cur;                            //  声明一个cur变量，用于赋值对象属性的当前值
            //  根据属性为opacity和其他，设置当前属性值
            if (attr == "opacity") {
                //  Math.round()函数用于四舍五入，opacity属性值为小数，所以用parseFloat转化为浮点数
                cur = Math.round(parseFloat(getStyle(obj, attr)) * 100);
            }
            else {
                //  属性不是opacity时，直接对返回的结果进行parseInt转化为整数
                cur = parseInt(getStyle(obj, attr));
            }
            var speed = (json[attr] - cur) / 6;      //  用iTarget减去cur当前属性值，然后除6来设置speed。此处用json[attr]代替iTarget，attr为属性名，json[attr]表示属性对应的值
            //  对得到的speed进行取整，speed大于0时，使用Math.ceil()函数进行向下取整数值，
            //  speed小于0时，使用Math.floor()函数进行向上取整数值
            speed = speed > 0 ? Math.ceil(speed) : Math.floor(speed);

            //  然后对当前值与目标值进行比较，相等则停止定时器，不相等则对当前值进行运算
            if (cur == json[attr]) {
                clearInterval(obj.timer);
                if (newFunc) { newFunc(); }      //  在定时器运行结束后，对newFunc进行判断，若传入newFunc，则调用newFunc方法，若没有传入newFunc，则不执行
            }
            else {
                if (attr == "opacity") {
                    obj.style["filter"] = "alpha(opacity=" + (cur + speed) + ");";
                    obj.style[attr] = (cur + speed) / 100;
                }
                else {
                    obj.style[attr] = cur + speed + "px";
                }
            }
        }
    }, 30);
}