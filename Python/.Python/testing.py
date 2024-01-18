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
