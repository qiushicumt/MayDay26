#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: learn/views.py

from django.shortcuts import render

# Create your views here.

def home(request):
    return render(request, 'home.html')
