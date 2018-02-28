# -*- coding:utf-8 -*-
# Python迭代器，迭代器是一个可以记住遍历的位置的对象，迭代器从集合的第一个元素开始向前访问，
#   直到所有元素被访问后结束，迭代器不能后退

# Python迭代器包含两个基本的方法：iter()和next()，字符串、列表或元组对象都可以用于创建迭代器
#   迭代器对象可以使用for循环进行遍历，也可以通过next()函数进行遍历。

# iter()函数用于创建迭代器对象
# 字符串创建迭代器对象、list对象创建迭代器对象、tuple(元组)对象创建迭代器对象
str1 = "liangdianshui"
iter1 = iter(str1)

list1 = [21, 22, 18, 55]
iter2 = iter(list1)

tuple1 = (5, 2, 8, 13)
iter3 = iter(tuple1)

# for循环遍历迭代器对象
for x in iter1:
    print(x, end=' ')
print('\n------------------------')

# next()函数遍历迭代器对象, next()函数在遍历完最后一个元素后，会抛出一个StopIteration的错误，表示无法继续遍历
while True:
    try:
        print(next(iter3))
    except StopIteration:
        break

