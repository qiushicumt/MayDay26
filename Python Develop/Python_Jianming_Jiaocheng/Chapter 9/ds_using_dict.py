#!/usr/bin/python
# -*- coding:utf-8 -*-
# Filename: ds_using_dict.py

'''
    字典是由一组组键值对组成的一组数据结构。
        在字典中，一个键值(Key)对应一个值(Value)，并且字典中的Key在这个字典中必须是唯一的，
        不能有相同的两个Key在一个字典中出现。所以只能使用不可变类型的对象作为字典中的键值(Key)

    字典的形式为 dict1 = {key1:value1, key2:value2, ...}
'''

'''
总结：   1、通过“字典名[Key]”这样的方式来获取字典中具体的Key对应的value值
        2、通过 del 语句，可以删除字典中的某一键值对，即 del dict1[key]
        3、for循环语句可以用来遍历字典中所有的键值对
        4、通过“字典名[Key]”的赋值方式，在字典中添加键值对，即 dict1[key] = value
'''

ab = {
    'Swaroop':'swaroop@swaroopch.com',
    'Larry':'larry@wall.org',
    'Matsumoto':'matz@ruby-lang.org',
    'Spammer':'spammer@hotmail.com'
}
print("Swaroop's address is", ab['Swaroop'])

del ab['Spammer']

print('\nThere are {} contacts in the address-book\n'.format(len(ab)))

for name, address in ab.items():
    print('Contact {} at {}'.format(name, address))

ab['Guido'] = 'guido@python.org'

if 'Guido' in ab:
    print("\nGuido's address is", ab['Guido'])

