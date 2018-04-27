#!/usr/bin/python
# -*- coding:utf-8 -*- 
# Filename: calc/views.py

from django.shortcuts import render
from django.http import HttpResponse
# Create your views here.

# 自定义add函数
def add(request):
    # 获取get方式传入的a、b参数的值
    a = request.GET['a']    
    b = request.GET['b']
    # 计算传入的两个参数的和
    c = int(a) + int(b)
    # 返回页面两个参数的和
    return HttpResponse('<h2>两个参数之和为：' + str(c) + '</h2>')
    
# 自定义一个add2函数
# add2函数的参数列表中包含a、b两个形参，表示接受的get请求后默认带两个参数 /a/b
def add2(request, a, b):
    c = int(a) + int(b)
    return HttpResponse('<h2>两个参数之和为：' + str(c) + '</h2>')