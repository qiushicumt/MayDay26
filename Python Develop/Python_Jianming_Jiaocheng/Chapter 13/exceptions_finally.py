#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: exceptions_finally.py

'''
    try...finally...语句块

    在程序退出前，finally语句会被执行，因此程序中打开的文件总会被关闭
'''

import sys
import time

f = None
try:
    f = open("poem.txt")
    while True:
        line = f.readline()
        if len(line) == 0:
            break
        print(line, end="")
        # stdout.flush()，可以让输出立即显示到屏幕上
        sys.stdout.flush()
        print("Press ctrl+c now")
        time.sleep(2)
except IOError:
    print("Could not find file poem.txt")
except KeyboardInterrupt:
    print("!! You cancelled the reading from the file.")
finally:
    if f:
        f.close()
    print("(Cleaning up: Closed the file)")