# -*- coding:utf-8 -*-
# python的循环语句包括for循环和while循环
# python中用于控制循环的语句为:break、continue、pass
#     break:用于跳出循环，结束整个循环
#     continue:用于跳出当前循环，直接进行下一次循环

# while循环
#   while循环1，当sum的值大于1000时，结束整个循环
sum = 0
count = 1 
while(count <= 100):
    sum += count
    if(sum > 1000):
        break
    count += 1
print(sum)
#   while循环2，计算1~100的奇数和
sum1 = 0
count1 = 1
while(count1 <= 100):
    if(count1 % 2 == 0):
        count1 += 1
        continue
    sum1 += count1
    count1 += 1
print(sum1)

# for循环
# Python中的for循环，可以用于遍历任何序列中的项目(一个列表或者字符串)
# for循环的语法为
#     for iterating_var in sequence:
#         statements(s)

# 1、for循环
for letter in "Hello 两点水":
    print(letter)

# 2、for...else...语句，在for循环正常执行完成后，执行else后面的语句
for num1 in range(10, 20):
    for i in range(2, num1):
        if num1%i == 0:
            j = num1/i
            print('%d 是一个合数' % num1)
            break
    else:
        print('%d 是一个质数' % num1)