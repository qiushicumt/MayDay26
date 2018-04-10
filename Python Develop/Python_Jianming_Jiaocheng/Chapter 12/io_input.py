#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: io_input.py

'''
    输入输出
'''


# 将字符串进行反转
def reverse(text):
    # 通过切片操作，将字符串进行反转。
    # [::-1]，切片操作的第一个参数表示起始位置，第二个操作表示终止位置，第三个参数表示步长，步长为1返回连续的文本，步长为
    #   -1，则返回反转后的文本
    return text[::-1]

def is_palindrome(text):
    return text == reverse(text)

something = input("Enter text:")
if is_palindrome(something):
    print("Yes, it is a palindrome")
else:
    print("No, it is not a palindrome")