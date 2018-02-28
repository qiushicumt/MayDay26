# -*- coding:utf-8 -*-
import math
# Python函数，python中内置了部分有用的函数，同时，可以自定义函数
# 函数名就是对一个函数对象的引用，所以可以将函数名赋值给一个变量，直接调用变量即可以调用函数

# 1、Python的部分系统函数
# 取绝对值函数abs
a = -1256
print(abs(a))
b = abs
print(b(a))
# max函数，根据传入的参数返回最大的值。max函数可以传入多个参数。
print(max(21, 3, 14, 6, 28))
# 类型转换函数，int函数、float函数、str函数等等
print(int('123'))
print(float('12.45'))
print(str(234))
print(bool(1))

# 2、Python中自定义函数
# Python中自定义的函数，函数代码块以def关键字开头，后接函数名和圆括号，圆括号中包含自定义参数
# 函数的第一行可以使用文档字符串，用于说明函数
# 函数语句内容以冒号(:)起始，并且缩进
# return [表达式] 用于结束函数，同时，可以选择不带return语句，相当于返回一个none

#   自定义一个函数
def sum1(num1, num2):
    "两个数据之和"
    return num1 + num2
print(sum1(2, 5))

#   可以自定义一个空函数，即在函数代码块中只写pass
def emptyFunc():
    pass

# 例子，自定义一个函数，返回一元二次方程的解
def quadratic(a, b, c):
    if((b*b - 4*a*c) >= 0):
        num1 = (-b + math.sqrt(b*b - 4*a*c)) / (2*a)
        num2 = (-b - math.sqrt(b*b - 4*a*c)) / (2*a)
        print("此一元二次方程有两个实数解，实数解1为：%d，实数解2为：%d", %(num1, num2))
    else:
        print("此一元二次方程没有实数解")



# 总结：
#   1、定义函数时，需要确定函数名和参数个数
#   2、有必要的话，可以先对参数的数据类型做检查
#   3、函数体内部可以使用return返回函数结果，当函数执行结束后没有return语句时，函数会自动 return None
#   4、函数可以同时返回多个值，实际上是返回一个tuple
