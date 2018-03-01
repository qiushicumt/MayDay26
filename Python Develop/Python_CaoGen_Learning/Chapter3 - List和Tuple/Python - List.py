# -*- coding: utf-8 -*-
# Python中的list
# Python中的list是一种有序的数据集合，可以进行添加和删除其中的元素
# Python中元素之间使用逗号进行分隔，元素可以是不同类型的数据
list1 = ['list元素1', 'a', 21343, "对萨队"]
print(list1)

# 通过下表，对list中的元素进行访问，起始下标为0
# 可以通过下标来访问单独某一个元素，也可以通过下标截取的方式访问list中的多个元素
print(list1[0])
print(list1[1:3])

# 通过append()方法，向list中添加新的元素
# 通过del语句，来删除list中的元素
list1.append(21325)
print(list1)
del list1[2]
print(list1)
