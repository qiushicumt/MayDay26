# -*- coding:utf-8 -*-
# Python中的Set，是一个无序的元素集合，与dict类似，但Set中不包含键，即只有值
# Set是无序的，所以输出Set时，与创建Set时，元素的顺序会是不一样的

# 1、创建Set
set1 = {"dajuihza", 21343, "老铁"}
print(set1)

# 2、set进行增删改查
# 通过add()方法，在set中增加新元素，重复添加元素时，不会添加到set中
set1.add("洗衣机")
print(set1)
# 通过remove()方法可以删除set
set1.add(62514)
print(set1)
set1.remove(21343)
print(set1)

# 3、set进行数学操作
# set可以进行并集、交集、差集操作
set2 = set('hello')
set3 = set(['p', 'y', 't', 'h', 'o', 'n'])
print(set2)
print(set3)
# 交集操作，使用 & 进行运算
set4 = set2 & set3
print(set4)
# 并集操作，使用 | 进行运算
set5 = set2 | set3
print(set5)
# 差集操作，使用 - 进行运算
set6 = set2 - set3
set7 = set3 - set2
print(set6)
print(set7)
