#Напишите программу, которая принимает на вход два числа и проверяет
# является ли одно число квадратом другого.
#Примеры:
#- 5, 25 -> да
#- 4, 16 -> да
#- 25, 5 -> да
#- 8,9 -> нет

#a = int(input('enter first number'))
#b = int(input('enter second number'))
#if (a ** 2 == b):
# print('yes, ', b, 'is a squre of ', a)
#elif(b ** 2 == a):
#    print('yes, ', a, 'is a squre of ', b)
#else:
#    print('no, numbers are not squres or each other')

a = int(input('enter first number'))
b = int(input('enter second number'))
def solution(a, b):
    return a ** 2 == b or b ** 2 == a
print(solution(a, b))

