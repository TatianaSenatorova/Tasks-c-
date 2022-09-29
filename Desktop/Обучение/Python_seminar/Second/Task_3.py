#Напишите программу, в которой пользователь будет задавать две строки,
# а программа - определять количество вхождений одной строки в другой.

x1 = str(input('Enter any simbols '))
x2 = str(input('Enter any simbols '))
count = 0
for i in range(len(x2) + 1):
    l = len(x1) + i
    if x1 == x2[i:l]:
          count += 1
print(count)