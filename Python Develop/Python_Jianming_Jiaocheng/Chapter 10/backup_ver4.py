#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: backup_ver4.py

'''
    备份程序 第四版
'''
import os
import time
# 备份目录及文件
source = ['/Users/mayday26/workspace/PythonWork/resources']
# 备份的目标目录
target_str = '/Users/mayday26/workspace/PythonWork/Python_Jianming_Jiaocheng/backup'
# 判断系统中是否已经存在目标目录，不存在则创建
if not os.path.exists(target_str):
    os.mkdir(target_str)
# 设置日期为子目录名称(os.sep是用于产生系统的分隔符)
# 将当前时间用作备份文件名称
today = target_str + os.sep + time.strftime('%Y%m%d')
now = time.strftime('%H%M%S')
# 添加注释到文件名称中
comment = input('Please enter a comment:')
if len(comment) == 0:
    target = today + os.sep + now + '.zip'
else:
    target = today + os.sep + now + '_' + comment.replace(' ', '_') + '.zip'
# 判断系统中子目录是否存在，不存在则创建
if not os.system.exists(today):
    os.mkdir(today)
    print('Successfully created directory', today)
# 创建zip命令
zip_command = 'zip -r {0} {1}'.format(target, ' '.join(source))

print('Zip command is:')
print(zip_command)
print('Running:')
if os.system(zip_command) == 0:
    print('Successful backup to', target)
else:
    print('Backup FAILED')

