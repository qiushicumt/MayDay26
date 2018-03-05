#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: function_default.py

'''
    函数的默认参数
    在函数的声明时，可以给形参设置一个默认值，在函数调用的时候，具有默认值的形参则不必传入实参值
    使用赋值运算符"="，给默认形参赋值
    注：1、在调用函数传递实参时，若给默认形参赋值，则默认形参的值为传入的实参值，若不赋值，则为声明函数时的默认值
        2、默认形参必须放在形参列表的最后
'''

def say(message, times = 1):
    print(message * times)

say('Hello')
say('world', 5)

print('Done!')
