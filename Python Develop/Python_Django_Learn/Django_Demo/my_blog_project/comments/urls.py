# -*- coding: utf-8 -*-
# Filename: comments/urls.py

from django.conf.urls import include, url
from . import views

# 定义命名空间
app_name = 'comments'
urlpatterns = [
    url(r'^article/(?P<article_pk>[0-9]+)/$', views.article_comment, name="article_comment"),
]
