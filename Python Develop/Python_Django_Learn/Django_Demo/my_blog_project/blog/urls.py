# -*- coding:utf-8 -*-
# Filename: urls.py

from django.conf.urls import url
# from django.contrib.admin import admin
from . import views

urlpatterns = [
    url(r'^index/', views.index, name="index"),
    url(r'^article/(?P<pk>[0-9]+)/$', views.article_detail, name="article_detail"),
    url(r'^archives/(?P<year>[0-9]{4})/(?P<month>[0-9]{1,2})/$', views.archives, name="archives"),
    url(r'^category/(?P<pk>[0-9]+)/$', views.category, name="category"),
]