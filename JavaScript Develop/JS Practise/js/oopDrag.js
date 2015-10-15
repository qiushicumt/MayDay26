// JavaScript source code
function Drag(id) {
    TuoZhuai.call(this, id);        //  call()用于继承父类对象，在子对象的构造函数中，父对象.call(this);this引用子对象;子对象继承父对象的属性
}
for (i in TuoZhuai.prototype) {
    Drag[i].prototype = TuoZhuai[i].prototype;
}
