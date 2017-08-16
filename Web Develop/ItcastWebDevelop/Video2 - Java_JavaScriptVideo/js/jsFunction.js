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