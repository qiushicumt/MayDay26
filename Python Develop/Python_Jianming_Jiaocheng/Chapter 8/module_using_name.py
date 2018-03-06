#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: module_using_name.py

'''
    每一个模块都有一个 __name__ 属性
    每一个python模块都定义了它的 __name__ 属性，如果它与 __main__属性相同，则代表这一模块是由用户独立运行的
'''

if __name__ == '__main__':
    print('This program is being run by itself')
else:
    print('I am being imprted from another module')