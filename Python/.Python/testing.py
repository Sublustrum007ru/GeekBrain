import os.path
import pandas as pd

# data = [int(i) for i in input("Введите кол-во ягод: ").split()]
# max_summa = 0
# for i in range(len(data)):
#     if max_summa < data[i - 1] + data[i] + data[(i + 1) % len(data)]:
#         max_summa = data[i - 1] + data[i] + data[(i + 1) % len(data)]
# print(max_summa)

# Автотест задача 2, семинар 6 (Повторение списков)

# Заполните массив элементами арифметической прогрессии. Её первый элемент a1 , 
# разность d и количество элементов n будет задано автоматически. Формула для 
# получения n-го члена прогрессии: an = a1 + (n-1) * d.

# a1 = 2
# d = 3
# n = 4

# # 2     (a1 + (n - 1) * d)
# # 5     (a1 + (n - 1) * d)
# # 8     (a1 + (n - 1) * d)
# # 11    (a1 + (n - 1) * d)

# massiv = []
# def arif(a1, d, n):
#     if n == 0:
#         return(massiv)
#     an = a1 + (n - 1) * d
#     massiv.insert(0, an)
#     arif(a1, d, n - 1)
# arif(a1, d, n)
# for i in range(len(massiv)):
#     print(f'{massiv[i]}')


# list1 = 1, 2, 3, 5, 8, 15, 23, 38

# def cub(arg1):
#     return arg1 * arg1
# massiv = []
# for i in list1:
#     if i % 2 == 0:
#         massiv.insert(0, i)

# print(f'{massiv}')

# data = [1, 2, 3, 5, 8, 15, 23, 38]

# res = list()

# for i in data:
#     if i % 2 == 0:
#         res.append((i, i * i))

# print(f'{res}')

# data = [1, 2, 3, 5, 8, 15, 23, 38]
# def select(f, col):
#     return [f(x) for x in col]

# def where(f, col):
#     return [x for x in col if f(x)]

# res = select(int, data)
# print(f'{res}')
# res = where(lambda x: x % 2 == 0, res)
# print(f'{res}')
# res = list(select(lambda x: (x, x ** 2), res))
# print(f'{res}')

# list_1 = [x for x in range(1, 20)]
# print(f'{list_1}')

# list_1 = list(map(lambda x: x + 10, list_1))
# print(f'{list_1}')

# data = '15 156 654 54 35 6 2 66 3 25 5'
# print(type(data))
# print(f'{data}')
# data = list(map(int, data.split()))   # Преобразование исходной строки data в список data состоящий из чисел
# print(type(data))
# print(f'{data}')

# data = [15, 65, 9, 36, 175]

# res = list(filter(lambda x: x % 10 == 5, data))
# print(f'Список до применения функции "filter" = {data}')
# print(f'Список после применения функции "filter" ={res}')


# def test(arg1):
#     result = list(enumerate(arg1))
#     return result
# cities = ['user1', 'user2', 'user3', 'user4']

# print(test(cities))

# cities.append('user5')

# print(test(cities))

# Работа с файлами
## a - Открытие и добавление данных.
##  * Позволяет дописывать что-то в имеющийся файл.
##  * Если вы попробуете дописать что-то в несуществующий файл, то файл будет создан

## r - Открытие для чтения файла
##  * Позволяет читать данные из файла.
##  * Если вы попробуете считать данные из файла, которого нет, программа выдаст ошибку

## w - Открытие для записи данных
##  * Позволяет записывать данные и создавать файл, если его не существует

## w+ 
##  * Позволяет открывать файл для записи и читать из него.
##  * Если файла не сузествует, он будет создан.

## r+
##  * Позволяет открывать файл для чтения и дописывания в него.
##  * Если файл не существует, программа выдаст ошибку


# def print_operation_table(operation, num_rows, num_columns):
#     a = [[operation(i, j) for j in range(1, num_columns + 1)] for i in range(1, num_rows + 1)]
#     for i in a:
#         print(*[f"{x:>3}" for x in i])

# print_operation_table(lambda x, y: x - y, 5, 5)


# def rhythm(str):
#     str = str.split()
#     list_1 = []
#     for word in str:
#         count = 0
#         for i in word:
#             if i in 'аеёиоуыэюя':
#                 count += 1
#         list_1.append(count)
#     return len(list_1) == list_1.count(list_1[0])
# stroka = 'Парам-пам-пам пам-парам'

# if len(stroka.split()) > 1:
#     if rhythm(stroka):
#         print('Парам пам-пам')
#     else:
#         print('Пам парам')
# else:
#     print(f'Количество фраз должно быть больше одной!')

# path = '.'
# num_files = len([f for f in os.listdir(path)
#                 if os.path.isfile(os.path.join(path, f))])

# print(f'{num_files}')

# input = int(input('Введите число от 1 до' 
#                   '{num_files}'))

# df = pd.read_csv('sample_data/california_housing_train.csv')
# df.head()

import random
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI':lst})
data.head()