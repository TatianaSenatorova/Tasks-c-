#Напишите программу, которая принимает на вход число N
# и выдает набор произведений чисел от 1 до N.
#Пример:
#- пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

import math

def RowOfNumbers(N):
        a = [1]
        for i in range(2, N + 1):
            a.append(math.factorial(i))
        return a        
N = int(input('Enter any number '))
a = RowOfNumbers(N)
print(a)

#Second variant
#def RowOfNumbers(N):
#        a = [1]
#        for i in range(1, N):
#            a.append(a[i - 1] * (i + 1))
#        return a        
 
#N = int(input('Enter any number '))
#a = RowOfNumbers(N)
#print(a)