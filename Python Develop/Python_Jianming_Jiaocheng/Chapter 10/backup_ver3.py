#!/usr/bin/python
# -*- coding: utf-8 -*-
# Filename: backup_ver3.py

'''
    备份文件 第三版
'''

import os
import time

# 源文件目录
source = ['/Users/mayday26/workspace/PythonWork/resources']
# 目标文件主目录
target_dir = '/Users/mayday26/workspace/PythonWork/Python_Jianming_Jiaocheng/backup'
# 文件主目录不存在则创建
if not os.path.exists(target_dir):
    os.mkdir(target_dir)
# 使用当前日期作为子目录的名称
# 将当前时间用作文件名称
today = target_dir + os.sep + time.strftime('%Y%m%d')
now = time.strftime('%H%M%S')
# 输入注释内容用作文件名
comment = input('Enter a comment --> ')
if len(comment) == 0:
    target = today + os.sep + now + '.zip'
else:
    target = today + os.sep + now + ' ' + comment.replace(' ', '_') + '.zip'
# 判断子目录是否存在，不存在则创建一个子目录
if not os.path.exists(today):
    os.mkdir(today)
    print('Successfully created directory', today)
# 创建zip命令
zip_command = 'zip -r {0} {1}'.format(target, ' '.join(source))
zip_command = 'zip -r {0} {1}'.format(target, ' '.join(source))

print('Zip command is:')
print(zip_command)
print('Running:')
if os.system(zip_command) == 0:
    print('Successful backup to', target)
else:
    print('Backup FAILED!')
