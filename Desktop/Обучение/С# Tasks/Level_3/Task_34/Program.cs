/*Написать программу замену элементов массива на противоположные*/

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

int[] NewArr(int [] arr)
{
    int [] newArray = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    newArray[i] = -arr[i];
    return newArray;
}



int [] arr_1 = FillMass(12, -9, 10);
Print(arr_1);
int [] newArr_1 = NewArr(arr_1);
Print(newArr_1);
