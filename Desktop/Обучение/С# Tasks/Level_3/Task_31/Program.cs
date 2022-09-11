/*Задать массив из 8 элементов и вывести их на экран */

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

Console.WriteLine("Enter a number of elements in mass: ");
int count = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a low bound of a mass: ");
int from = int.Parse(Console.ReadLine());
Console.WriteLine("Enter an upper bound of a mass: ");
int to = int.Parse(Console.ReadLine());

int [] arr_1 = FillMass(count, from, to);
Print(arr_1);