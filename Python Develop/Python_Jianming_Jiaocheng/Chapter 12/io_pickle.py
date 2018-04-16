#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: io_pickle.py

'''
    pickle标准模块，通过pickle模块，可以将一个Python对象存储到一个文件中。
'''

# 引入pickle模块
import pickle

# 存储对象的文件名称
shoplistfile = 'shoplist.data'

# 需要购买的物品清单
shoplist = ['apple', 'banana', 'mango', 'carrot']

# 以写入的方式打开文件
f = open(shoplistfile, 'wb')

# 存储对象至文件中
pickle.dump(shoplist, f)

# 关闭文件
f.close()

# 清除shoplist对象
del shoplist

# 重新打开文件，以只读的方式
f = open(shoplistfile, 'rb')

# 将文件中的对象赋值给一个新的变量storedlist
storedlist = pickle.load(f)
print(storedlist)

