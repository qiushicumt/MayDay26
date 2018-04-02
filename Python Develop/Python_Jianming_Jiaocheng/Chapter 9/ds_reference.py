#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: ds_reference.py

'''
    引用，是指当把一个对象赋值给一个变量时，实际是将变量名指向该对象
    所以，当需要创建一个序列或者列表这种复杂对象的副本时，需要使用切片(slice)的操作，而不是使用赋值(=)操作
'''

print('Simple Assignment')

shoplist = ['apple', 'mango', 'carrot', 'banana']
mylist = shoplist

del shoplist[0]

print('shoplist is:', shoplist)
print('mylist is:', mylist)

print('Copy by making a full slice')
mylist = shoplist[:]

del mylist[0]

print('shoplist is:', shoplist)
print('mylist is:', mylist)