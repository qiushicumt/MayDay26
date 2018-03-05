#!/usr/bin/python3
# -*- coding:utf-8 -*-
# # Filename: function_local.py

'''
    变量的作用域，函数中定义的变量，作用域为函数块内部
'''

num = 50
def changed_local(num):
    print('num is:', num)
    num = 3
    print('Changed local num to', num)

changed_local(num)
print('Function changed num, num is', num)
print('Done!')