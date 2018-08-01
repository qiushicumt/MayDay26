# -*- coding: utf-8 -*-
# Filename: models.py

from django.db import models
from django.contrib.auth.models import User
from django.urls import reverse
from django.utils.six import python_2_unicode_compatible

class Category(models.Model):
    category_name = models.CharField("分类名称", max_length = 100)

    def __str__(self):
        return self.category_name

class Tag(models.Model):
    tag_name = models.CharField("标签名称", max_length = 100)

    def __str__(self):
        return self.tag_name

class Article(models.Model):
    article_title = models.CharField("文章标题", max_length = 100)
    article_body = models.TextField("文章正文")
    article_create_time = models.DateTimeField("文章创建时间")
    article_modified_time = models.DateTimeField("文章修改时间")
    article_excerpt = models.CharField("文章摘要", max_length = 200, blank = True)      # blank = True，表示可以为空值
    article_category = models.ForeignKey(Category)
    article_tags = models.ManyToManyField(Tag, blank = True)
    article_author = models.ForeignKey(User)

    def __str__(self):
        return self.article_title

    def get_absolute_url(self):
        return reverse("blog:article_detail", kwargs={'pk': self.pk})

    # 设置一个内部类Meta，在其中设置Article的一些属性
    class Meta:
        ordering = ['-article_create_time', 'article_title']