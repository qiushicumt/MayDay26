#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: function_keyword.py

'''
    关键字参数
    在调用函数时，给指定的参数名赋值，则可以不遵循函数形参列表中形参的顺序进行赋值
    给指定的形参赋值，不指定的形参则赋值为默认值
'''

def func(a, b = 5, c = 10):
    print('a is', a, ', b is', b, ', c is', c)

func(10, b = 8)
func(20, c = 88)
func(b = 35, a = 9)

print('Done!')