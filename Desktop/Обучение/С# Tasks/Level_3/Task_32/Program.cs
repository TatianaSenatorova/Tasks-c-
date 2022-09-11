 /*Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран*/

 void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
}

int [] FillMass(int count, int from, int to)
{
    Random r = new Random();
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    arr[i] = r.Next(from, to);
    return arr;
}

int [] arr_1 = FillMass(8, 0, 2);
Print(arr_1);
