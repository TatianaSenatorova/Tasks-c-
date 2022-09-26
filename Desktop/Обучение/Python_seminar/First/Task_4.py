#Напишите программу, которая будет принимать на вход дробь
#и показывать первую цифру дробной части числа.
#*Примеры:*
#- 6,78 -> 7
#- 5 -> нет
#- 0,34 -> 3

def NumAfterComma(N):
    if N % 1 == 0:
        print('no numbers after comma')
    else: 
     result = int(N * 10 % 10)
     print('the number after comma: ', result)
N = float(input('enter a fractional number N: '))
NumAfterComma(N)
