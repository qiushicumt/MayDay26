#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: ds_using_list.py

'''
    list(列表)，是一种有序的数据集合，用方括号括起来

'''

shoplist = ['apple', 'mango', 'carrot', 'banana']

print('I have', len(shoplist), 'items to purchase.')

print('These items are:', end = '')
for item in shoplist:
    print(item, end=' ')

print('\nI also have to buy rice.')
shoplist.append('rice')
print('My shopping list is now ', shoplist)

print('I will sort my list now')
shoplist.sort()
print('Sorted shopping list is', shoplist)

print('The first item I will buy is', shoplist[0])
olditem = shoplist[0]
del shoplist[0]
print('I bought the ', olditem)
print('My shopping list is now', shoplist)