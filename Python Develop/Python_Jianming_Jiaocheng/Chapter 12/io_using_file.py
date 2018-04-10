#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: io_using_file.py

'''
    python操作文件，进行文件的read、write、readline等操作
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

