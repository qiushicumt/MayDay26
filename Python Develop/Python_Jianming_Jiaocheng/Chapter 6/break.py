#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: break.py

'''
    break语句可以用于结束整个循环
    当循环运行遇到break语句时，会立即跳出循环，继续执行循环以外的语句
'''

running = True

while running:
    chars = input('Enter somethings here: ')
    if chars == 'quit':
        break
    # len()函数，可以计算并返回字符串的长度
    print('The length you have enter is: ', len(chars))

print('Done!')
