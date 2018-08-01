# -*- coding: utf-8 -*-
# Filename: comments/views.py

from django.shortcuts import render, get_object_or_404, redirect
from blog.models import Article

from .models import Comment
from .forms import CommentForm

# 创建文章评论的视图函数
def article_comment(request, article_pk):

    article = get_object_or_404(Article, pk=article_pk)             # 获取被评论的文章

    if request.method == 'POST':
        form = CommentForm(request.POST)

        if form.is_valid():
            comment = form.save(commit=False)
            comment.article = article
            comment.save()
            return redirect(article)

        else:
            comment_list = article.comment_set.all()
            context = {
                'article' : article,
                'form' : form,
                'comment_list' : comment_list
            }

            return render(request, 'blog/article_detail.html', context=context)

    return redirect(article)
