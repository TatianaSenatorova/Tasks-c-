#Напишите программу, которая принимает на вход цифру, 
# обозначающую день недели, и проверяет, является ли этот день выходным.
#Пример:
#- 6 -> да
#- 7 -> да
#- 1 -> нет

N = int(input('enter a number of any day of week: '))
if(N == 1 or N == 2 or N == 3 or N == 4 or N == 5):
    print('No, it\'s a weekday')
elif (N == 6 or N == 7):
    print('Yes, it\'s a weekend day')
else:
    print('You enter a wrong number. Enter a number from 1 to 7')

