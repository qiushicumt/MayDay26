#!/usr/bin/python3
# -*- coding:utf-8 -*-
# Filename:continue.py

# continue语句，循环语句块在执行时遇到continue语句，会立刻结束当前循环，跳到循环条件处，进行判断，执行下一次循环

running = True

while running:
    strings = input('Please enter somethings: ')
    if strings == 'quit':
        break
    if len(strings) < 5:
        print('Too small!')
        continue
    print('Input is of sufficient length')
else:
    print('The loop is over.')

print('Done!')