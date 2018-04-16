#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: io_using_file.py

'''
    python操作文件，进行文件的read、write、readline等操作
    open()函数可以打开一个文件，默认打开方式为read，添加参数'w'，可以实现以可写入的方式打开文件
        open('文件名')         ---- 以只读的方式打开文件
        open('文件名', 'w')    ---- 以写入的方式打开文件
    变量名.write(文件内容)      ---- 向文件中写入内容
    变量名.close()             ---- 关闭文件
    变量名.readline()          ---- 返回读取到的文件的每一行，包括换行符
'''

poem = '''\
Programing is fun
When the work is done
If you wanna make your work also fun:
    use Python!
'''

# 打开文件进行编辑
f = open('poem.txt', 'w')

# 向文件中添加文本
f.write(poem)

# 添加完成后，关闭文件
f.close()

# 打开文件，默认打开方式为read
f = open('poem.txt')
while True:
    line = f.readline()
    if len(line) == 0:
        break
    print(line, end='')

f.close()

