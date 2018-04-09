#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: oop_objvar.py

'''
	类的变量(字段)，字段是绑定在类与对象的命名空间中的普通变量，代表着这些变量名仅在类与对象所存在的上下文中有效
    字段分为两种类型，类变量和对象变量
        类变量可以被属于该类的所有实例访问，类变量只有一个，当类的实例对象改变了类变量时，其他实例中该类变量同样发生了改变
        对象变量由类的独立对象或者实例所有，不会被其他实例或对象所改变
'''
# 定义一个有名字的机器人类
class Robot:
    population = 0

    def __init__(self, name):
        # 初始化数据
        self.name = name
        print("(Initializing {})".format(self.name))
        # 每创建一个机器人实例对象，population变量+1
        Robot.population += 1
    
    def die(self):
        print("{} is being destroyed".format(self.name))
        Robot.population -= 1

        if Robot.population == 0:
            print("{} was the last one.".format(self.name))
        else:
            print("There are still {:d} robots working.".format(Robot.population))

    def say_hi(self):
        print("Greetings, my masters call me {}.".format(self.name))

    @classmethod
    def how_many(cls):
        print("We have {:d} robots.".format(cls.population))

droid1 = Robot("R2-D2")
droid1.say_hi()
Robot.how_many()

droid2 = Robot("C-3P0")
droid2.say_hi()
Robot.how_many()

print("\nRobots can do some work here.\n")
print("Robots have finished their work. So let's destroy them.")
droid1.die()
droid2.die()

Robot.how_many()
