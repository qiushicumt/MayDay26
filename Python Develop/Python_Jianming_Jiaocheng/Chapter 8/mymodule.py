#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename: mymodule.py

# 这是一个会被其他python程序引用的模块，此模块程序需要和引用程序放在同一目录下

def say_hi():
    print('hi, this is mymodule speaking.')

__version__ = '0.2'