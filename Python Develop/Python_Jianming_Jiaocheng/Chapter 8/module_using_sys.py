#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: module_using_sys.py

'''
    Python模块
    通过import语句，在程序的开始处导入相关模块。下例中导入sys模块，即导入的为python系统模块
    模块中包含的变量由符号'.'进行引用，即 sys.argv
    注：通过语句 from...import，可以省略sys.，来操作模块中的变量。一般不推荐此用法
'''

import sys

print('The command line arguments are:')
for i in sys.argv:
    print(i)
print('\n\nThe PYTHONPATH is', sys.path, '\n')

print('Done!')