#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: ds_using_tuple.py

'''
    元组(tuple)：用于将多个对象保存在一起。元组是一个序列，所以可以使用len()函数获取元组的长度。
    元组中可以包含一个元组。
    可以通过下标索引来获取元组中指定的某一项的值

'''

zoo = ('python', 'elephant', 'penguin')
print('Number of animals in the zoo is:', len(zoo))

new_zoo = 'monkey', 'camel', zoo
print('Number of cages in the new zoo is ', len(new_zoo))
print('All animals in new zoo are', new_zoo)
print('Animals brought from old zoo are', new_zoo[2])
print('Last animal brought from old zoo is', new_zoo[2][2])
print('Number of animals in the new zoo is', len(new_zoo) - 1 + len(new_zoo[2]))