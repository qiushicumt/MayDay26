# -*- coding:utf-8 -*-

# tuple是一种有序列表，但是tuple不像list，tuple在初始化完成后就不可改变
# tuple不存在增、删、改的操作，只有查询操作，即只能获取其中的某一个元素值

# 1、创建tuple
# 创建tuple时，列表中括号包围起来，列表中的每一个元素之间用逗号隔开，括号
# 可以省略，直接用一组元素进行赋值
tuple1 = ("liangdianshui", "two water", "两点水", 123)
tuple2 = "liangdianshui", "two water", "两点水", 1234
# 可以创建一个不包含任何元素的空tuple
tuple3 = ()
# tuple中只有一个元素时，逗号不能省略
tuple4 = (123,)
tuple5 = (123)
print(tuple1)
print(tuple2)
print(tuple3)
print(tuple4)
print(tuple5)

# 2、tuple中的元素访问通过下标索引进行，下标的起始是0
print(tuple1[2])
print(tuple2[1])

# 3、在tuple中，元素不可更改，当tuple中元素为list类型数据时，
# 可以通过变更list中的内容，达到更改tuple内容的目的
list1=[12345, 55231]
list2=[32143, 231432]
tuple6=("liangdianshui", "two water", "两点水", list1)
tuple7=("liangdianshui", "two water", "两点水", list2)

# 4、可以使用del语句删除整个tuple，但是不能删除tuple中的元素
tuple8=("好妹妹乐队", "haomeimei", [2134, 2131])
print(tuple8)
del tuple8
