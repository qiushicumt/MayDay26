#!/usr/bin/env python3
# -*- coding:utf-8 -*-
# Filename:if.py

number = 23
guess = int(input('Enter an integer: '))

if guess == number:
    print('Congratulations, you guess it.')
    print('(but you do not win any prizes!)')
elif guess < number:
    print('No, it\'s a little higher than that')
else:
    print('No, it is a little lower than that')

print('Done!')

