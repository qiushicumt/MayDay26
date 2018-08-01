# -*- coding: utf-8 -*-
# Filename: blog/templatetags/blog_tags.py

from ..models import Article, Category
from django import template

register = template.Library()

@register.simple_tag
def get_recent_articles(num = 5):
    return Article.objects.all().order_by('-article_create_time')[:num]

@register.simple_tag
def archives():
    return Article.objects.dates('article_create_time', 'month', order='DESC')

@register.simple_tag
def get_categories():
    return Category.objects.all()

