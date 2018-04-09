#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename:oop_init.py

'''
	类的初始化方法 __init__
'''

class Person:
	def __init__(self, name):
		self.name = name

	def say_hi(self):
		print("Hello, my name is", self.name)

p = Person("Mike")
p.say_hi()