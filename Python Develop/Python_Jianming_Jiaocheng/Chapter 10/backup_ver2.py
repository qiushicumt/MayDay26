#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: backup_ver2.py
'''
    备份文件程序的第二个版本
    第二个版本是在主目录中创建一个以当前日期作为名称的子目录，
        然后在子目录中创建以当前时间作为名称的zip文件
'''

import os
import time
# 备份的源文件
source = ['/Users/mayday26/workspace/PythonWork/resources']
# 备份的目标文件目录
target_dir = '/Users/mayday26/workspace/PythonWork/Python_Jianming_Jiaocheng/backup'
# 目标目录不存在的时候，创建一个目标文件夹
if not os.path.exists(target_dir):
    os.mkdir(target_dir)    
# 将当前日期当作备份目录下的子目录的名称
today = target_dir + os.sep + time.strftime('%Y%m%d')
# 将当前时间作为zip文件的文件名
now = time.strftime('%H%M%S')
target = today + os.sep + now + '.zip'

# 判断子目录是否存在，不存在则创建一个
if not os.path.exists(today):
    os.mkdir(today)
    print('Successfully created directory', today)

# 创建zip的command命令
zip_command = 'zip -r {0} {1}'.format(target, ' '.join(source))

print('Zip command is:')
print(zip_command)
print('Running:')
if os.system(zip_command) == 0:
    print('Successful backup to', target)
else:
    print('Backup FAILED')