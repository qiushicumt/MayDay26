# -*- coding:utf-8 -*-

# python中函数的返回值，return[表达式]可以用于退出函数，向函数的调用方返回一个表达式。若返回时没有参数，则返回None

# 定义两个数之和
# isinstance(object, classinfo)函数，用于数据类型检查，检查object是否为classinfo类型
def sum1(num1, num2):
    if not (isinstance(num1, (int, float)) or isinstance(num2, (int, float))):
        raise TypeError('参数类型错误')
    return num1 + num2
print(sum1(8, 12))

# 定义一个求商和余数的函数
def division1(num3, num4):
    m = num3 % num4
    n = (num3 - m) / num4
    return n, m

num5, num6 = division1(9, 4)
tuple1 = division1(9, 4)

print(num5, num6)
print(tuple1)
# 此函数返回两个返回值，当函数具有多个返回值时，实际是创建一个tuple，然后返回tuple的值
