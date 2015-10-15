// JavaScript source code
//  函数的实参数组arguments对象
function argumentCounter() {
    alert("You gave me " + arguments.length + " arguments.");
    alert("Argument3 is:" + arguments[2]);
}
argumentCounter("Straw man", "Frank", "John");
/* 
//  =================================== 字符串的各种方法 ====================================
//  string.split();     //  split()方法用于对字符串进行分割，字符串以split方法传入的字符进行分割，返回分割后形成的数组
//  string.charAt();    //  charAt()方法用于获取字符串制定位置的字符，例，string.charAt(2)表示获取string的位置索引2上的字符。（注：若指定的字符串位置没有字符，则返回""）
//  string.slice()      //  slice()方法用于获取字符串中的一部分的字符，例，string.slice(1,5)表示获取string从1到4上的字符。（注：slice方法在指定的位置找不到字符则会忽略）
//  string.indexOf();   //  indexOf()方法用于找出字符第一次出现的位置或者截取字符串中的子串。
window.onload = function () {
    var myCat = "The color of first cat is white";
    var result = myCat.split(" ");
    alert(result[2]);

    var str1 = "mycomputer";
    var str2 = "com";
    alert(str1.slice(2, str2.length + 2) == str2);         //alert(str1.slice(2, 5) == str2);

    var catStr = "born 20/09/2004 (mother Yellow Bess): Doctor Hobbles the 2nd, Noog";
    var strcon = catStr.indexOf(":");
    var str3 = catStr.slice(strcon+2, catStr.length);
    alert(str3.split(", "));
}

=================================== 数组push方法 ====================================
function range(intNum) {
    var result = [];
    for (var i = 0; i <= intNum; i++) {
        result.push(i);
    }
    return result;
}
alert(range(4));
*/