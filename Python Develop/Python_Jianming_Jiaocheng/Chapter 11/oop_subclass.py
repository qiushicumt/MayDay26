#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: oop_subclass.py

'''
    基类与派生类s

'''

# 创建一个SchoolMember基类
class SchoolMember:
    def __init__(self, name, age):
        self.name = name
        self.age = age
        print("(Initialized SchoolMember: {})".format(self.name))

    def tell(self):
        print("Name:'{}' Age:'{}'".format(self.name, self.age), end=" ")

# 创建一个Teacher派生类
class Teacher(SchoolMember):
    def __init__(self, name, age, salary):
        SchoolMember.__init__(self, name, age)
        self.salary = salary
        print("(Initialized Teacher: {})".format(self.name))

    def tell(self):
        SchoolMember.tell(self)
        print("Salary:'{:d}'".format(self.salary))

# 创建一个Student派生类
class Student(SchoolMember):
    def __init__(self, name, age, marks):
        SchoolMember.__init__(self, name, name)
        self.marks = marks
        print("(Initialized Student: {})".format(self.name))

    def tell(self):
        SchoolMember.tell(self)
        print("Marks:'{:d}'".format(self.marks))

# 分别创建两个派生类的实例对象
teacher1 = Teacher("Mrs.Shrividya", 38, 25800)
student1 = Student("Swaroop", 26, 88)

print()

members = [teacher1, student1]
for member in members:
    member.tell()