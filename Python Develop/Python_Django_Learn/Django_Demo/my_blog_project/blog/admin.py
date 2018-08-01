# -*- coding:utf-8 -*-
# Filename: admin.py

from django.contrib import admin
from .models import Article, Tag, Category

class ArticleAdmin(admin.ModelAdmin):
    list_display = ['article_title', 'article_create_time', 'article_modified_time', 'article_category', 'article_author']

admin.site.register(Article)
admin.site.register(Tag)
admin.site.register(Category)