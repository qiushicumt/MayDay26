#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: exceptions_handle.py

'''
    try...except...语句用来处理异常。
        正常的语句放在try代码块中，错误处理代码要放在except代码块中
'''

try:
    text = input("Enter something --> ")
except EOFError:
    print("Why did you do an EOF on me?")
except KeyboardInterrupt:
    print("You cancelled the operation.")
else:
    print("You entered {}".format(text))