#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: calc/views.py

from django.http import HttpResponse
from django.shortcuts import render

def index(request):
    return render(request, 'home.html')

def add(request):
    a = request.GET['a']
    b = request.GET['b']
    c = int(a) + int(b)
    return HttpResponse('<h2>传入的两个参数之和为：' + str(c) + '</h2>')

def add2(request, a, b):
    c = int(a) + int(b)
    return HttpResponse('<h2>传入的两个参数之和为：' + str(c) + '</h2>')
