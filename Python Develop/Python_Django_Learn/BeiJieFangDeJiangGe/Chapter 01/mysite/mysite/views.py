# -*- coding:utf-8 -*-
# Filename: views.py

from django.http import HttpResponse

def first_page(request):
    return HttpResponse("<h2>被解放的姜戈</h2>")