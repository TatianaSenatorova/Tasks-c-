#Реализуйте алгоритм перемешивания списка.
import random

N = int(input('Enter any number '))

def FillList(N):
    a = []
    for i in range(0, N):
        a.append(random.randint(-100, 100))
    return a     

def ChangePosition(a):
    random.shuffle(a)
    return(a)
    
a = FillList(N)
print(a)
print('перемешанный список', ChangePosition(a))
