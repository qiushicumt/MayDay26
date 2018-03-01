# -*- coding:utf-8 -*-
# Python中的字符串

# Python中使用[]进行字符串截取，索引下标的起始数字是0，单一个数字表示截取单一字符，
# 冒号连接两个数字，冒号两边分别代表着字符串的截取从哪里开始，并到哪里结束。
name = "My name is Mike"
print(name[0] + '\n')
print(name[-4] + '\n')
print(name[11:14] + '\n')
print(name[11:15] + '\n')
print(name[:5] + '\n')
print(name[5:] + '\n')

word = "friends"
find_the_evil_in_your_friends = word[0] + word[2:4] + word[-3:-1]
print(find_the_evil_in_your_friends)

# Python的字符串具有各种方法，replace()方法用于替换字符串中的指定的字符
phone_num = "1388-963-6680"
hiding_num = phone_num.replace(phone_num[:9], '*'*9)
print(hiding_num)

# 实例1、查找相关字符
search = "168"
num_a = "1386-168-0006"
num_b = "1681-222-0006"
num_c = "1892-436-0168"
print(search + " is at " + str(num_a.find(search)) + " to " + str(num_a.find(search) + len(search)) + " of " + num_a)
print(search + " is at " + str(num_b.find(search)) + " to " + str(num_b.find(search) + len(search)) + " of " + num_b)
print(search + " is at " + str(num_c.find(search)) + " to " + str(num_c.find(search) + len(search)) + " of " + num_c)