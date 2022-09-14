/*Определить, присутствует ли в заданном массиве, некоторое число */

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

void FindNum(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            Console.WriteLine($"Yes, the number {number} is present in mass");
            break;
        }
        else if (arr[i] == arr[arr.Length - 1])
            Console.WriteLine($"No, the number {number} is absent in mass");
    }

}

Console.WriteLine("Enter any number: ");
int number = int.Parse(Console.ReadLine());

int[] arr_1 = FillMass(15, -9, 10);
Print(arr_1);
FindNum(arr_1, number);


