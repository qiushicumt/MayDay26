/*  1、求n个数的累加
var sum1 = 0;
function getSum(n) {
    sum1 += n;
    n--;
    if(n > 0 ) {
        getSum(n);
    }
    return sum1;
}
*/

//  1、求n个数的累加
function getSum(n) {
    if (n === 1) {
        return n;
    }
    return n + getSum(n - 1);
}

//  2、JavaScript自定义构造函数
//  创建一个Student构造函数
function Student(name, gender, age, score) {
    this.name = name;
    this.gender = gender;
    this.age = age;
    this.score = score;
    this.sayHi = function () {
        console.log("Hello，我是 " + this.name);
    }
}