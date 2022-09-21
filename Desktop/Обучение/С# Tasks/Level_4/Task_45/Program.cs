/*Показать числа Фибоначчи*/

void Fibonacci(int N)
{
    
    int [] arr = new int [N];
    arr[0] = 1;
    arr[1] = 1;
    Console.WriteLine($"F1 = {arr[0]}");
    Console.WriteLine($"F2 = {arr[1]}");
 for (int i = 2; i < arr.Length; i++)
 {
    arr[i] = arr[i - 1] + arr[i - 2];
    Console.WriteLine($"F{i+1} = {arr[i]}");
 }
}

Console.Write($"Enter number N for Fibonacci: ");
int N = int.Parse(Console.ReadLine());

Fibonacci(N);
