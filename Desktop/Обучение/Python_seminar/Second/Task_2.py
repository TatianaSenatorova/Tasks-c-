#Для натурального n создать словарь индекс-значение,
#состоящий из элементов последовательности 3n + 1.
#Пример:
#Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

def FillDictionary(N):
    dict = {}
    for i in range(1, N + 1, 1):
        dict[i] = 3 * i + 1
    return dict
        

N = int(input('Enter any number '))
dict = FillDictionary(N)
print(dict)