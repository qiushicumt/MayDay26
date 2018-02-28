# -*- codin:utf-8 -*-
# dict可以存储键值对，方便查找

# 1、创建dict
# dict用{}包括其中的键值对，每一对键值对之间用逗号(,)分隔，每一个键值对中的键和值之间用冒号(:)分隔
# dict = {key1:value1, key2:value2}
# 在一个dict中，键值必须是唯一的，值可以相同，也可以不同，值可以为任意类型数据
dict1 = { "user1":"张三", "user2":"李四", "user3":"赵六" }
print(dict1)

# 2、dict的增删改查
# 在dict中增加一对键值对，直接给dict赋一个键值对即可
dict1['user4'] = "老铁"
print(dict1)
# 通过del语句，在dict中进行删除操作，可以删除dict中的一个元素，也可以直接删除整个dict
# 调用 clear() 方法可以清除字典中的所有元素
del dict1['user3']
print(dict1)
# dict中的键不可改变，值可以改变
dict1['user1'] = "张翼德"
print(dict1)
