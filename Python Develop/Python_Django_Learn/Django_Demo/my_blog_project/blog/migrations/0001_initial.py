# -*- coding: utf-8 -*-
# Generated by Django 1.11.8 on 2018-07-09 09:16
from __future__ import unicode_literals

from django.conf import settings
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
    ]

    operations = [
        migrations.CreateModel(
            name='Article',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('article_title', models.CharField(max_length=100, verbose_name='文章标题')),
                ('article_body', models.TextField(verbose_name='文章正文')),
                ('article_create_time', models.DateTimeField(verbose_name='文章创建时间')),
                ('article_modified_time', models.DateTimeField(verbose_name='文章修改时间')),
                ('article_excerpt', models.CharField(blank=True, max_length=200, verbose_name='文章摘要')),
                ('article_author', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to=settings.AUTH_USER_MODEL)),
            ],
        ),
        migrations.CreateModel(
            name='Category',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('category_name', models.CharField(max_length=100, verbose_name='分类名称')),
            ],
        ),
        migrations.CreateModel(
            name='Tag',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('tag_name', models.CharField(max_length=100, verbose_name='标签名称')),
            ],
        ),
        migrations.AddField(
            model_name='article',
            name='article_category',
            field=models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='blog.Category'),
        ),
        migrations.AddField(
            model_name='article',
            name='article_tags',
            field=models.ManyToManyField(blank=True, to='blog.Tag'),
        ),
    ]
