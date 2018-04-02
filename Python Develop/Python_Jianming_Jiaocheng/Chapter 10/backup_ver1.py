#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: backup_ver1.py

'''
    备份文件的流程
        先将源文件目录放在一个列表中，然后将目标目录放在一个str字符串中
        接着将备份文件压缩成zip格式
        在压缩前，判断目标文件夹是否存在，不存在，则创建一个目标文件夹
        接着设置压缩命令的参数，第一个参数为zip格式压缩文件，第二个参数为源文件目录
'''

import os
import time

# 将需要备份的文件和目录放在一个列表中
source = ['/Users/mayday26/workspace/PythonWork/resources']

# 设置备份的目标目录
target_dir = '/Users/mayday26/workspace/PythonWork/Python_Jianming_Jiaocheng/backup'

# 将备份文件压缩成zip格式
# os.sep()函数是用于添加当前程序所运行的系统里的分隔符
target = target_dir + os.sep + time.strftime('%Y%m%d%H%M%S') + '.zip'

# 当目标目录不存在时，进行创建
if not os.path.exists(target_dir):
    os.mkdir(target_dir)    # 创建目录

# zip命令将文件打包成zip格式
zip_command = 'zip -r {0} {1}'.format(target, ' '.join(source))

print('Zip command is:')
print(zip_command)
print('Running:')

# os.system()函数，可以将命令放到系统的命令行进行运行
if os.system(zip_command) == 0:
    print('Successful backup to', target)
else:
    print('Backup FAILED')