#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: learn/views.py

from django.shortcuts import render

# Create your views here.
from django.http import HttpResponse

# 创建显示主页的函数index，接收参数request即用户发出的页面请求
def index(request):
    return HttpResponse('<h2>欢迎来到自强学堂Django基础教程!</h2>')