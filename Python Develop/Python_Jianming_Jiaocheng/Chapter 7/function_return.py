#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: function_return.py

'''
    return语句，用于中断函数，从函数中直接返回一个值
    一个函数若没有写return语句，则函数存在一个默认的返回值None，即没有返回值的函数默认返回None
'''

# 返回两个数中的数值大的数
def maximum(num1, num2):
    if num1 > num2:
        return num1
    elif num1 == num2:
        return 'The numbers are equal'
    else:
        return num2

print(maximum(28, 35))

print('Done!')