#Напишите программу, которая принимает на вход координаты точки (X и Y),
# причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
# (или на какой оси она находится).
#Пример:
#- x=34; y=-30 -> 4
#- x=2; y=4-> 1
#- x=-34; y=-30 -> 3

def QuarterCoordinates(X, Y):
    if (X > 0 and Y > 0):
        print('1 quater')
    elif (X < 0 and Y > 0):
        print('2 quater')
    elif (X < 0 and Y < 0):
        print('3 quater')
    else:
        print('4 quater')
    
X = int(input('enter coordinate X: '))
Y = int(input('enter coordinate Y: '))
QuarterCoordinates(X, Y)