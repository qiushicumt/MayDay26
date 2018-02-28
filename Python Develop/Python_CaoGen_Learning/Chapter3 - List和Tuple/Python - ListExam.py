# -*- coding:utf-8 -*-

# =========== list实例 =============

# 1、一个产品，需要列出产品的用户，这时候可以使用一个List来表示
user = ['liangdainshui', 'twowater', '两点水']
print('1.产品用户')
print(user)

# 2、需要统计有多少个用户，此时，len()函数可以获得list中元素的个数
len(user)
print('\n2.统计有多少个用户')
print(len(user))

# 3、当需要查看具体的每一个用户时，可以通过索引访问list中每一个元素，索引是从0开始的
print('\n3.查看具体用户')
print(user[0] + ', ' + user[1] + ', ' + user[2])

# 4、新加了一个新的用户，需要在List的末尾添加一个用户
# append()函数，可以在List的末尾添加元素
print('\n4.在末尾添加新用户')
user.append('茵茵')
print(user)

# 5、又新增一个用户，此用户为VIP级别，需要放在List的第一位
user.insert(0, 'VIP用户')
print('\n5.指定位置添加用户')
print(user)

# 6、发现茵茵就是VIP用户，因此需要从list列表中删除茵茵
# pop()函数可以从List列表中删除最后一个元素
user.pop()
print('\n6.删除最后一个用户')
print(user)

# 7、用户“liangdianshui”删除了账号，需要在List中删除指定的元素
# pop(x)函数用于删除指定索引x处的元素
user.pop(1)
print('\n7.删除指定位置上的用户')
print(user)

# 8、用户“两点水”想修改自己的昵称
user[len(user) - 1] = "两点水2"
print('\n8.修改指定位置上元素的值')
print(user)

# 9、在List中保存用户昵称的同时也要保存账号信息
# 即，在List中保存不同的数据类型的数据
newUser = [['VIP用户', 11111], ['liangdianshui', 22222], ['两点水', 33333]]
print('\n9.在List中保存不同的类型的数据')
print(newUser)