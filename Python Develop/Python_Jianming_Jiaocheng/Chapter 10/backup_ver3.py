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
