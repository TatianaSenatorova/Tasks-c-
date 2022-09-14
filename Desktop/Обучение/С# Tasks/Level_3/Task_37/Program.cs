/*В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]*/

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

int NumEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count += 1;
    }
    return count;
}

int NumsInMassAndSegment(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            count += 1;
    }
    return count;
}

int[] arr_1 = FillMass(123, 0, 1000);
Print(arr_1);
Console.WriteLine($"Amount of numbers in mass which belong to the segment [10, 99] : " + NumsInMassAndSegment(arr_1));

