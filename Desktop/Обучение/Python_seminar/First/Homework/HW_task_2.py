#Напишите программу для. проверки истинности утверждения
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.



def CheckLogik(X, Y, Z):
    if (not (X or Y or Z)) == (not X and not Y and not Z):
         print('Утверждение истинно')
    else:
         print('Утверждение ложно')
   
X = input('enter first predicate X: ')
Y = input('enter second predicate Y: ')
Z = input('enter third predicate Z: ')
CheckLogik(X, Y, Z)