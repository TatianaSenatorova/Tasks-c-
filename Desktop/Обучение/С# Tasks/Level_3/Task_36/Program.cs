/*Задать массив, заполнить случайными положительными трёхзначными числами.
Показать количество нечетных\четных чисел*/

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

int NumUnEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
            count += 1;
    }
    return count;
}

int[] arr_1 = FillMass(15, 100, 1000);
Print(arr_1);
Console.WriteLine($"Even numbers in mass: " + NumEvenElements(arr_1));
Console.WriteLine($"Uneven numbers in mass: " + NumUnEvenElements(arr_1));



