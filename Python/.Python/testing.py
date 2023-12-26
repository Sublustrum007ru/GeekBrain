list = [1, 21 ,3, -46, 53, -6, 117]
size = len(list)
print(type(list))
for i in range(size-1):
    min_position = i
    for j in range(i, size):
        if list[j] < list[min_position]:
            min_position = j
    list[i], list[min_position] = list[min_position], list[i]
print(list)