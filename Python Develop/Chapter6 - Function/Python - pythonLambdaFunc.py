# -*- coding:utf-8 -*-
# Python匿名函数
# python使用lambda来创建匿名函数
#   1、lambda只是一个表达式，函数主体比def定义的函数要简单很多
#   2、lambda主体只是一个表达式，所以lambda匿名函数只能实现简单的逻辑
#   3、lambda函数拥有自己的命名空间，所以不能访问自有参数列表之外或全局命名空间里的参数
# 函数的语法为： lambda[arg1 [, arg2, ...argn]]:expression

num2 = 100
sum1 = lambda num1 : num1 + num2

num2 = 10000
sum2 = lambda num1 : num1 + num2

print(sum1(1))
print(sum2(1))

# lambda表达式中的自由变量，在lambda表达式被调用的时候才进行赋值
# lambda匿名函数的主体只能有一个表达式，不需要包含return语句