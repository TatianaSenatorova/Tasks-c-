#Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
#Пример:
#- 6782 -> 23
#- 0,56 -> 11

x = str(input('Enter any double number '))
chars = '.,'
res = x.translate(str.maketrans('', '', chars))
sum = 0
for i in range(0, len(res)):
       a = int(res[i])
       sum += a
print(sum)

