#1. Напишите программу, которая принимает на вход число N и выдаёт 
# последовательность из N членов.
#Пример:
#Для N = 5: 1, -3, 9, -27, 81

def RowOfNumbers(N):
        a = []
        for i in range(0, N):
            a.append((-3) ** i)
        return a        
 
N = int(input('Enter any number '))
a = RowOfNumbers(N)
print(a)