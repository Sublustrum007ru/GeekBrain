var1 = '5 4'       # количество элементов первого и второго множества
var2 = '10 30 5 7 9' # элементы первого множества через пробел
var3 = '2 30 4 5'   # элементы второго множества через пробел

def createset(arg):
    newset = set()
    for i in arg:
        if i != ' ':
            newset.add(i)
    return newset
list1 = var2.split(' ')
list2 = var3.split(' ')
set1 = createset(list1)
set2 = createset(list2)
print(set2.intersection(set1))