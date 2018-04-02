#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: ds_str_methods.py

'''
    字符串对象(str)的相关方法
        startwith()方法，用于判断字符串是否以特定的字符串开始
        in语句可以检查特定的字符串是否是当前字符串的一部分
        find()方法，可以用于定位字符串中的子字符串的位置，若不包含子字符串，则返回-1
'''

nameStr = 'Swaroop'

if nameStr.startswith('Swa'):
    print('Yes, the string starts with "Swa"')

if 'a' in nameStr:
    print('Yes, it contains the string "a"')

if nameStr.find('war') != -1:
    print('Yes, it contains the string "war"')

delimiter = '-*-'
mylist = ['Brazil', 'Russia', 'India', 'China']
print(delimiter.join(mylist))