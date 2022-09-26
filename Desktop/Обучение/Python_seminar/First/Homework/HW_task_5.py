#Напишите программу, которая принимает на вход координаты двух точек и
# находит расстояние между ними в 2D пространстве.
# Пример:
# - A (3,6); B (2,1) -> 5,09
# - A (7,-5); B (1,-1) -> 7,21

from cmath import sqrt


def DistanceTwoPoints(X1, Y1, X2, Y2):
    dist = sqrt(((X2 - X1)**2 + (Y2 - Y1)**2))
    return dist
  
X1 = int(input('enter X1 coordinate of first point '))
Y1 = int(input('enter Y1 coordinate of first point '))
X2 = int(input('enter X2 coordinate of second point '))
Y2 = int(input('enter Y2 coordinate of second point '))

print(DistanceTwoPoints(X1, Y1, X2, Y2))