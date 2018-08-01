# -*- coding:utf-8 -*-
# Filename: views.py

from django.http import HttpResponse
from django.shortcuts import render, get_object_or_404
from .models import Article, Tag, Category
from comments.forms import CommentForm
import markdown

def index(request):
    article_list = Article.objects.all()
    # for article in article_list:
    #     article.article_body = article.article_body[:40]
    return render(request, "blog/index.html", context={
        'title' : '我的博客 - 首页',
        'article_list' : article_list
    })

# 博客文章详情页
def article_detail(request, pk):
    article = get_object_or_404(Article, pk=pk)
    article.article_body = markdown.markdown(article.article_body, extensions=[
        'markdown.extensions.extra',
        'markdown.extensions.codehilite',
        'markdown.extensions.toc',
    ])
    form = CommentForm()
    comment_list = article.comment_set.all()

    context = {
        'article' : article,
        'form' : form,
        'comment_list' : comment_list
    }
    return render(request, 'blog/article_detail.html', context=context)


# 博客归档显示
def archives(request, year, month):
    article_list = Article.objects.filter(article_create_time__year=year, article_create_time__month=month)
    return render(request, 'blog/index.html', context={'article_list' : article_list})

# 博客分类
def category(request, pk):
    cate = get_object_or_404(Category, pk=pk)
    article_list = Article.objects.filter(article_category = cate)
    return render(request, 'blog/index.html', context={'article_list' : article_list})

'''

# 博客文章详情页
def article_detail(request, pk):
    article = get_object_or_404(Article, pk=pk)
    article.article_body = markdown.markdown(article.article_body,
                                             extensions=[
                                                 'markdown.extensions.extra',
                                                 'markdown.extensions.codehilite',
                                                 'markdown.extensions.toc',
                                             ])
    return render(request, "blog/article_detail.html", context={'article' : article})

# 博客文章详情页
def article_detail(request, pk):
    article = get_object_or_404(Article, pk=pk)
    return render(request, "blog/article_detail.html", context={
        'article' : article
    })


defdex(request):
    return render(request, "blog/index.html", context = {
        'title' : '我的博客 - 首页',
        'welcome' : '欢迎访问我的博客首页'
    })


def index(request):
    return HttpResponse("欢迎来到我的博客!")
'''