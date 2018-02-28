#!/usr/bin/env python3
# -*- coding:utf-8 -*-
# Filename: while.py

'''
while循环中，while后面接循环条件，为true时，程序执行while语句块，
执行完while语句块后判断循环条件是否为true，为true则循环执行while语句块，
为false时，会去执行else后的可选语句块
else代码块在while循环条件变为false时执行，else代码块存在的话，则总是会
被执行。
可以通过break语句来中断循环
'''

number = 26
running = True

while running:
    guess = int(input('Enter an integer: '))
    if guess == number:
        print('Conguratulations, you get it!')
        running = False
    elif guess < number:
        print('No, it\'s a little higher than that')
    else:
        print('No, it is a little lower than that')
else:
    print('The while loop is over!')

print('Done!')
