a = [1, 21 ,3, -46, 53, -6, 117]
n = len(a)
print(type(a))
for k in range(n-1):
    min = k
    for i in range(k, n):
        if a[i] < a[min]:
            min = i
    a[k], a[min] = a[min], a[k]
print(a)