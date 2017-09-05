//  定义一个两个数范围求和的函数
function getSum(num1, num2) {
    //  将两个传入的参数与0进行或运算，保证进行计算的值是正确的
    num1 = num1 || 0;
    num2 = num2 || 0;
    var sum = 0;
    for (var i = num1; i <= num2; i++) {
        sum += i;
    }
    return sum;
}

/**
 * 求圆的面积
 * @param r
 * @returns {number}
 */
function getCircle(r) {
    r = r || 1;
    var area = r * r * Math.PI;
    return area;
}

/**
 * 求两个数中的最大值
 * @param num1
 * @param num2
 * @returns {*|number}
 */
function getMax(num1, num2) {
    num1 = num1 || 0;
    num2 = num2 || 0;
    var max = num1;
    if (num1 < num2) {
        max = num2;
    }
    return max;
}

/**
 * 求三个数中的最大值
 * @param num1
 * @param num2
 * @param num3
 * @returns {*|number}
 */
function getThreeMax(num1, num2, num3) {
    num1 = num1 || 0;
    num2 = num2 || 0;
    num3 = num3 || 0;
    return (num1 > num2 ? num1 : num2) > num3 ? (num1 > num2 ? num1 : num2) : num3;
}

/**
 * 求一组数中的最大值
 * @param array
 * @returns {*}
 */
function getMaxInArray(array) {
    array = array || [];
    var max = array[0];
    for (var i = 1; i < array.length; i++) {
        if (max < array[i])
            max = array[i];
    }
    return max;
}

/**
 * 求一组数中的最小值
 * @param array
 * @returns {*}
 */
function getMinInArray(array) {
    array = array || [];
    var min = array[0];
    for (var i = 1; i < array.length; i++) {
        if (min > array[i])
            min = array[i];
    }
    return min;
}

/**
 * 判断一个数是否为素数
 * @param num1
 * @returns {string}
 */
function getSuShu(num1) {
    num1 = num1 || 1;
    var tmp = 0;
    for (var i = 1; i <= num1; i++) {
        if ((num1 % i) === 0 ) {
            tmp++;
        }
    }
    return tmp > 2 ? "这个数不是素数" : "这个数是素数";
}

/**
 * 获取一组数中的素数和合数
 * @param array {Array}
 */
function getSushuHeshu(array) {
    array = array || [];
    var sushuArray = [];
    var heshuArray = [];
    for (var i = 0; i < array.length; i++) {
        var tmp = 0;
        for (var j = 1; j <= array[i]; j++) {
            if(array[i] % j === 0)
                tmp++;
        }
        if(tmp === 2) {
            sushuArray[sushuArray.length] = array[i];
        } else {
            heshuArray[heshuArray.length] = array[i];
        }
    }
    console.log("这组数中所有的素数为：" + sushuArray);
    console.log("这组数中所有的合数为：" + heshuArray);
}

/**
 * 求一个数的阶乘
 * @param num
 * @returns {number}
 */
function getFactorial(num) {
    num = num || 0;
    var fac = 1;
    for(var i = num; i >= 1; i--) {
        fac *= i;
    }
    return fac;
}

function getFactorialSum(num) {
    num = num || 0;
    var sum = 0;
    for(var i = num; i >= 1; i--) {
        sum += getFactorial(i);
    }
    return sum;
}