/*Найти кубы чисел от 1 до N*/

void CubNumber(int number)
{
    for (int i = 1; i <= number; i++)
    Console.Write($"{Math.Pow(i, 3)}, ");
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());


CubNumber(number);