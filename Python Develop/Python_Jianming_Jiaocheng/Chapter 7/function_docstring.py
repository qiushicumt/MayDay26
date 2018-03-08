#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: function_docstring.py

'''
    按照约定，文档字符串是一串多行字符串，第一行以某一大写字母开始，
    以句号结束。第二行为空行，后跟第三行开始是任何详细的解释说明。
    通过函数的 __doc__ 属性，可以获取函数的文档字符串
'''

def print_max(num1, num2):
    '''
        打印两个数中的最大数。

        这两个应该都是整数
    '''
    num1 = int(num1)
    num2 = int(num2)

    if num1 > num2:
        print(num1, 'is maximum')
    else:
        print(num2, 'is maximum')

print_max(8, 6)
print(print_max.__doc__)
