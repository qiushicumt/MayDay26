#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: function_varargs.py

'''
    函数的可变参数
    在声明函数时，若不确定函数的具体参数的个数，可以使用可变参数
    在可变参数的前面使用"*"来表示这个参数为可变参数
    注： '*'修饰的可变参数，传入的所有实参被收集到一个元组中
         '**'修饰的可变参数，传入的所有实参被收集到一个字典中
'''

def total(a = 5, *numbers, **phonebook):
    print('a', a)

    # 使用for循环来遍历第一个可变参数中的所有项目
    for single_item in numbers:
        print('single_item', single_item)

    # 使用for循环遍历第二个可变参数中的所有项目
    for first_part, second_part in phonebook.items():
        print(first_part, second_part)

total(10, 1, 2, 3, Jack = 1123, John = 1134, Inge = 1238)

print('Done!')
