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

var1 = '3 4'       # количество элементов первого и второго множества
var2 = '1 2 3' # элементы первого множества через пробел
var3 = '1 2 3 4'   # элементы второго множества через пробел

# На выходе

# 3 5 

def sort(arg):
    size = len(arg)
    numb = [int(i) for i in arg]
    for i in range(size - 1):
        min_position = i
        for j in range(i, size):
            if numb[j] < numb[min_position]:
                min_position = j
        numb[i], numb[min_position] = numb[min_position], numb[i]
    result = [str(i) for i in numb]
    return result

def createset(arg):
    newset = set()
    for i in arg:
        if i != " ":
            newset.add(i)
    return newset

def createlist(arg):
    newlist = arg.split(" ")
    return newlist

list1 = createlist(var1)
list2 = createlist(var2)
list3 = createlist(var3)

if int(list1[0]) > int(list1[1]):
    x = list(createset(list3).intersection(createset(list2)))
    print(" ".join(sort(x)))
else:
    y = list(createset(list2).intersection(createset(list3)))
    print(" ".join(sort(y)))