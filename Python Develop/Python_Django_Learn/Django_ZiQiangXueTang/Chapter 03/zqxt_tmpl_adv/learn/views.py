#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: views.py

from django.shortcuts import render

# Create your views here.

# 显示一个基本的字符串在网页上
def home(request):
    myStr = u"我在自强学堂学习Django，用Django来建网站"
    # 相当于设置一个变量为 string， 将字符串内容通过变量 string传递到html页面上
    return render(request, 'home.html', {'string': myStr})
