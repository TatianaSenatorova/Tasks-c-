/*Найти произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.*/

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int[] FillMass(int count, int from, int to)
{
    Random r = new Random();
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
        arr[i] = r.Next(from, to);
    return arr;
}

int NewArrLength(int[] arr)
{
    int newArrLength = 0;
    if (arr.Length % 2 == 0)
        newArrLength = arr.Length / 2;
    else newArrLength = (arr.Length / 2) + 1;
   return newArrLength;
}

int[] MultiplyPairs(int[] arr, int newArrLength)
{
    int[] newArr = new int[newArrLength];
    int k = 0;
    for (int i = 0; i < newArrLength; i++)
    {
        newArr[k] = arr[i] * arr[arr.Length - i - 1];
        k += 1;
    }
    return newArr;
}

int[] arr_1 = FillMass(11, 0, 100);
Print(arr_1);
NewArrLength(arr_1);
int[] newArray = MultiplyPairs(arr_1, NewArrLength(arr_1));
Print(newArray);

