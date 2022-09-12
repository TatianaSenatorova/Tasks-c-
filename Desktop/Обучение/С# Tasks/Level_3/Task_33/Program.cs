/*Задать массив из 12 элементов, заполненных числами из [-9,9].
Найти сумму положительных/отрицательных элементов массива*/

 void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int [] FillMass(int count, int from, int to)
{
    Random r = new Random();
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    arr[i] = r.Next(from, to);
    return arr;
}

int SumPosNums(int [] arr)
{
    int sumPosNums = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        sumPosNums += arr[i];
    }
    return sumPosNums;
}

int SumNegativeNums(int [] arr)
{
    int sumNegNums = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        sumNegNums += arr[i];
    }
    return sumNegNums;
}

int [] arr_1 = FillMass(12, -9, 10);
Print(arr_1);
Console.WriteLine($"Summ positive numbers:" + (SumPosNums(arr_1)));
Console.WriteLine($"Summ negative numbers:" + (SumNegativeNums(arr_1)));
