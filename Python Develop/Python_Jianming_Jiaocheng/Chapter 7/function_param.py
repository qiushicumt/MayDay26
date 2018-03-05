#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: function_param.py

'''
    函数可以接收参数，在函数体中进行使用，在函数名称后的括号内定义函数可以接收的参数
    函数可以接收多个参数，每一个参数之间用逗号隔开
    定义函数时，函数列表中的参数称为形参
    调用函数时，向函数传递的参数称为实参
'''

def max_num(num1, num2):
    if num1 > num2:
        print(num1, 'is maximum.')
    elif num1 < num2:
        print(num2, 'is maximum.')
    else:
        print(num1, 'is equal to', num2)

x = 34
y = 24
max_num(x, y)

print('Done!')