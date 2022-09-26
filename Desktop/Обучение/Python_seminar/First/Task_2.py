#Напишите программу, которая на вход принимает 5 чисел и находит максимальное из них.
#Примеры:
#- 1, 4, 8, 7, 5 -> 8
#- 78, 55, 36, 90, 2 -> 90

#first variant
#list = []
#for i in range(0, 5):
#    list.append(int(input('enter number')))
#print(max(list))


#list = []
#for i in range(0, 5):
#    list.append(int(input('enter number')))
#max = list[0]
#for i in list:
#    if i > max:
#       max = i
#print(max)

list = []
for i in range(0, 5):
    list.append(int(input('enter number')))
max = list[0]
for i in list:
    if i > max:
       max = i
print(max)