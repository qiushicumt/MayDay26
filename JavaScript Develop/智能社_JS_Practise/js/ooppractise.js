// JavaScript source code
//  JavaScript中的面向对象编程  构造函数一般用于设置对象的属性，原型一般用于设置对象的方法
//  脚本7 面向对象选项卡
//  将面向过程的程序改写为面向对象的程序，第一步使函数没有嵌套
var oBtn = null;
var oDiv = null;
window.onload = function () {
    new TabSwitch();
}
function TabSwitch() {
    var oDiv1 = document.getElementById("wrappage");
    oBtn = oDiv1.getElementsByTagName("input");
    oDiv = oDiv1.getElementsByTagName("div");
    for (var i = 0; i < oBtn.length; i++) {
        oBtn[i].index = i;
        oBtn[i].onclick = fnClick;
    }
}
function fnClick() {
    for (var i = 0; i < oBtn.length; i++) {
        oBtn[i].className = "";
        oDiv[i].style.display = "none";
    }
    this.className = "active";
    oDiv[this.index].style.display = "block";
}
/*  
//  脚本6 
function Student(props) {
    this.name = props.name || "匿名";
    this.grade = props.grade || 1;
}
Student.prototype.hello = function () {
    alert("Hello, " + this.name + "!");
}
function createFunc(props) {
    return new Student(props || {});
}
var xiaoming = createFunc();
xiaoming.hello();
//var xiaoming = createFunc(
//    { name: "xiaoming" }
//    );
//xiaoming.hello();
==================================================
//  脚本5 OOP中的prototype
function Person(firstName) {
    this.firstname = firstName;
}
Person.prototype.sayHello = function () {
    alert("Welcome " + this.firstname);
}
var person1 = new Person("Frank");
var person2 = new Person("John");
var helloFunc = person1.sayHello();
helloFunc;

var Student = {
    name: "Robot",
    height: 1.6,
    run: function () {
        alert(this.name + " is running...");
    }
};
var Bird = {
    fly: function () {
        alert(this.name + " is flying...");
    }
}
var xiaoming = {
    name: "XiaoMing"
};
xiaoming.__proto__ = Student;
xiaoming.run();
alert(xiaoming.height);         //  xiaoming从原型Student处继承了height属性
xiaoming.__proto__ = Bird;      
//  xiaoming.run();     xiaoming的原型指向了Bird，Bird中不存在run方法，此处无法调用run()
xiaoming.fly();                 //  xiaoming从原型Bird处继承了fly方法
alert(xiaoming.height);         //  xiaoming的原型变为Bird，Bird中不存在height属性，此处会alert undefined         
================================================
//  脚本4 OOP中构造函数的this
function CreateObj(iAdjective) {
    this.adjective = iAdjective;
    this.speak = function () {
        alert("ajideo " + this.adjective);
    }
}
//  使用new创建对象，方式为“new+构造函数”
var myObj = new CreateObj("111111");
myObj.speak();

//  脚本3 OOP中的this
function speakFunc(line) {
    alert("The " + this.adjective + "rabbit speaks: '" + line +"'");
}
//  用一个对象直接量赋值给一个变量就可以直接声明一个对象
//  对象直接量可以由简单的键值对组成，如{a:10, b:20}，此对象两个属性a、b
var whiteRabbit = {adjective:"white", speak:speakFunc};             
var fatRabbit = { adjective: "fat", speak: speakFunc };
whiteRabbit.speak("Rabbit1");
fatRabbit.speak("Rabbit2");

//  脚本2 OOP构造函数
function createObj(iName, iPhoneNum) {              //  自定义的一个构造函数  
    var obj = new Object();
    obj.name = iName;
    obj.phoneNum = iPhoneNum;
    obj.showName = function () {
        alert("我的名字是：" + obj.name);
    }
    obj.showPhoneNum = function () {
        alert("我的电话号码是：" + obj.phoneNum);
    }
    return obj;
}
var obj1 = createObj("张三", "18802633322");
obj1.showName();
obj1.showPhoneNum();
var obj2 = createObj("李四", "13912545566");
obj2.showName();
obj2.showPhoneNum();

//  脚本1 OOP基本代码
var myObj = new Object();
myObj.name = "张三";
myObj.phoneNum = "13812771122";
myObj.showName = function () {
    alert("我的名字是：" + myObj.name);
}
myObj.showPhoneNum = function () {
    alert("我的电话号码是：" + myObj.phoneNum);
}
myObj.showName();
myObj.showPhoneNum();
*/