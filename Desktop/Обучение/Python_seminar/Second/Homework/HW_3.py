#Задайте список из n чисел последовательности (1+1/n)^n и выведите на экран их сумму.

import math as m

N = int(input('Enter any number '))

def FillList(N):
    a = []
    for i in range(0, N, 1):
        a.append(m.pow((1 + 1/(i + 1)), i + 1))
    return a

def SumElements(a):
    sum = 0
    for i in range(0, N):
        sum += a[i]
    return sum
        
a = FillList(N)
print(a)
print(SumElements(a))





