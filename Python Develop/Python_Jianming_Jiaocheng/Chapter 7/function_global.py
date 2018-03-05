#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: function_global.py

# global语句，调用global语句修饰变量，则变量会成为全局变量

num = 25 

def func_global():
    global num
    print('num is', num)
    num = 28
    print('Changed num to', num)

func_global()
print('Value of num is', num)

print('Done!')
