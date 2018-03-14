#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: ds_using_list.py

'''
    list(列表)，是一种有序的数据集合，用方括号括起来
    使用for...in循环可以遍历列表中的每一项
    append()方法：list列表可以通过append方法向列表中添加新的项
    sort()方法：   list列表可以通过sort方法将list列表项中的所有项进行排序。
        注：使用sort方法对list列表进行排序，会改变list列表
    del语句可以直接删除列表中的某一项
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