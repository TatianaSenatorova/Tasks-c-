#Задайте список из N элементов, заполненных числами из промежутка [-N, N].
# Найдите произведение элементов на указанных позициях.
# Позиции хранятся в файле file.txt в одной строке одно число.

from re import A


N = int(input('Enter any number '))

#Задаем массив
a = []
for i in range(-N, N + 1):
        a.append(i)
print(a)

#Записываем позиции массива в текстовый файл
file = open("C:/Users/Татьяна/Desktop/Обучение/Python_seminar/Second/file.txt", "w")
for index in range(1, 2 * N +1, 1):
     file.write(str(index))
     file.write('\n')
file.close()

#Вводим позиции. Элементы на этих позициях будут использоваться для вычисления произведения
pos1 = int(input('Enter any position in list '))
pos2 = int(input('Enter another position in list '))

#Считываем позиции из файла
b = int(open('C:/Users/Татьяна/Desktop/Обучение/Python_seminar/Second/file.txt').read().split('\n')[pos1 - 1])
print(a[b - 1])
c = int(open('C:/Users/Татьяна/Desktop/Обучение/Python_seminar/Second/file.txt').read().split('\n')[pos2 -1])
print(a[c - 1])

#Вычисляем произведение элементов, находящихся на введенных пользователем позициях
multiply = a[b - 1] * a[c - 1]
print("Произведение элементов, находящихся на ",  pos1,  " и ",  pos2,  "позициях, ", multiply)


