# Даны два неупорядоченных набора числе(может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые 
# встречаются в обоих наборах.
# На входе подается 2 числа через пробел n m
# n - кол-во элементов первого множества
# m - кол-во элементов второго множества
# Затем подаются элементы каждого множества через пробел в виде строки.
# !!!! Писать input() не надо. !!!!

# Пример

# На входе

var1 = '5 4'       # количество элементов первого и второго множества
var2 = '10 30 5 7 9' # элементы первого множества через пробел
var3 = '2 30 4 5'   # элементы второго множества через пробел

# На выходе

# 3 5 
def sort(list):
    size = len(list)
    for i in range(size - 1):
        min_position = i
        for j in range(i, size):
            if list[j] < list[min_position]:
                min_position = j
        temp = list[i]
        list[i] = list[min_position]
        list[min_position] = list[i]
    print(list)
    return list

def createset(arg):
    newset = set()
    for i in arg:
        if i != ' ':
            newset.add(i)
    return newset

newset = set()
for i in createset(var2.split(' ')):
    for j in createset(var3.split(' ')):
        if j == i:
            newset.add(j)

newlist = list(newset)
sort(newlist)
