/*Найти сумму чисел одномерного массива стоящих на нечетной позиции*/

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

int SumNumsOnUnevenPos(int[] arr)
{
    int sumNums = 0;
    for (int i = 0; i < arr.Length; i += 2)
        sumNums += arr[i];
    return sumNums;
}

int[] arr_1 = FillMass(10, 0, 100);
Print(arr_1);
Console.WriteLine($"Summ of elements on uneven positions: " + SumNumsOnUnevenPos(arr_1));
