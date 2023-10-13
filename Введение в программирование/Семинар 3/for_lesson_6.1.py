numbers=[2,5,13,7,6,4]
size=len(numbers)
index=0
sum=0
avg=0
while index<size:
    sum=sum+numbers[index]
    index=index+1
avg=sum/size
print(avg)