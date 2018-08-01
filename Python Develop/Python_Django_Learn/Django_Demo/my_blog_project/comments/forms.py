# -*- coding: utf-8 -*-
# Filename: comments/forms.py

from django import forms
from .models import Comment

# 表单对应着数据库中的一张表的数据，此处的CommentForm类继承 form.ModelForm类
class CommentForm(forms.ModelForm):
    class Meta:
        model = Comment                                 # model = Comment表明表单对应的数据库模型为Comment类
        fields = ['name', 'email', 'url', 'text']       # fields指定了表单需要显示的字段

