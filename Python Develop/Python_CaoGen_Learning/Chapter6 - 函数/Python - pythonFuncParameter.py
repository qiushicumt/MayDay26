# -*- coding:utf-8 -*-
# Python的函数参数

# 1、函数的默认参数
# Python中，函数在调用的时候如果没有给参数传值，可以使用默认参数值，若给参数传值，则使用传递的参数值，不使用默认的参数值
# Python函数的参数列表中的最后一个参数才可以设置默认参数值

# 定义一个输出用户信息的函数
def print_user_info(name, age, gender = '男'):
    print("昵称: {}".format(name), end = " ")
    print("年龄: {}".format(age), end = " ")
    print("性别: {}".format(gender))
    return;

print_user_info("两点水", 28, "女")
print_user_info("two water", 34)

# 2、函数的关键字参数
# 在给函数传参的时候，可以直接设置指定参数的值
# 调用函数直接指定给参数赋值，指定参数值的时候，可以忽略参数在形参列表中的顺序
print_user_info(name = "落落", gender = "女", age = 29)

# 3、可变参函数(不定长函数)
# 在定义函数的时候，函数参数个数不确定的时候，可以定义不定长参数，Python通过元祖tuple来接收不定长参数
def print_user_info_hobby(name, age, gender, * hobby):
    print("昵称: {}".format(name), end = ", ")
    print("年龄: {}".format(age), end = ", ")
    print("性别: {}".format(gender), end = ", ")
    print("爱好: {}".format(hobby))
    return ;
print_user_info_hobby("Frank", 38, "男", "足球", "网球", "游泳")

# 4、强制关键字参数
# Python的函数参数可以强制使用关键字参数作为参数，将参数放在 * 后，可以用于关键字参数
# print_userInfo(name, *, age, gender)函数中age、gender都是关键字参数，即在调用函数时候，必须带上参数名进行传参