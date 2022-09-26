#Напишите программу, которая по заданному номеру четверти, 
# показывает диапазон возможных координат точек в этой четверти (x и y).

def Coordinates(N):
    if (N == 1):
        print('coordinates are: X > 0, Y > 0')
    elif(N == 2):
        print('coordinates are: X < 0, Y > 0')
    elif(N == 3):
        print('coordinates are: X < 0, Y < 0')  
    elif(N == 4):
        print('coordinates are: X > 0, Y < 0') 
    else:
        print('you enter a wrong number')  
        
N = int(input('enter number of quater of coordinates (from 1 to 4): '))
Coordinates(N)