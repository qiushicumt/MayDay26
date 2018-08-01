# -*- coding:utf-8 -*-
# Filename: comments/models.py

from django.db import models
from django.utils.six import python_2_unicode_compatible

@python_2_unicode_compatible
class Comment(models.Model):
    name = models.CharField("用户名", max_length=100)
    email = models.EmailField("电子邮箱", max_length=200)
    url = models.URLField(blank=True)
    text = models.TextField()
    created_time = models.DateTimeField(auto_now_add=True)

    article = models.ForeignKey('blog.Article')

    def __str__(self):
        return self.text[:20]

