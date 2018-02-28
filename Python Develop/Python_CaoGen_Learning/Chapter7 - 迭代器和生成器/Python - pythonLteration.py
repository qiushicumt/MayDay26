# -*- coding:utf-8 -*-
# Python迭代器
# 在Python中，通过for循环遍历list、tuple，这种遍历叫迭代。在python中，无论对象是否有下标，只要是可迭代对象，都可以通过for循环进行迭代

# 1、for迭代字符串、list、dict
#   迭代字符串
for char1 in "liangdianshui":
    print(char1, end = " ")
print('\n')

#   迭代list
list1 = [12, 3332, 221, 453, 893]
for num1 in list1:
    print(num1, end = " ")
print('\n')

#   迭代dict
dict1 = {"name":"两点水", "age":28, "gender":"男"}
for key1 in dict1:
    print(key1, end = " ")
print('\n')

for value1 in dict1.values():
    print(value1, end = " ")
print('\n')

for key2, value2 in dict1.items():
    print(key2, value2)
print('\n')
