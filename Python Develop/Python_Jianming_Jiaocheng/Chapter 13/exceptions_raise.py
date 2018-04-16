#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: exceptions_raise.py

'''
    通过raise语句，可以抛出异常

'''

class ShortInputException(Exception):
# 一个自定义的异常类
    def __init__(self, length, atleast):
        Exception.__init__(self)
        self.length = length
        self.atleast = atleast

try:
    text = input("Enter something --> ")
    if len(text) < 3:
        raise ShortInputException(len(text), 3)
except EOFError:
    print("Why did you do an EOF on me?")
except ShortInputException as ex:
    print(("ShortInputException: The input was " + "{0} long, expected at least {1}").format(ex.length, ex.atleast))
else:
    print("No exception was raised.")
