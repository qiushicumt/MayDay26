#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: for.py

'''
for循环，for循环的执行，会在循环条件范围内进行。else语句块为可选语句块，当循环条件不满足
时，执行else语句块。else语句块若存在的话，总会在for循环语句块结束后执行
'''

'''
range()函数返回一个数字序列，输入参数为两个数字，序列从第一个数字开始，到第二个数字结束，
第二个数字不包含在序列中。range函数还可以包含第三个参数，第三个参数为序列的两个数字之间
的跨度间隔
'''
for i in range(1, 8):
    print(i)
else:
    print('The for loop is over.')

print('Done!')
