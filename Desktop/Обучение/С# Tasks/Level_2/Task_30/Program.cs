/*Показать кубы чисел, заканчивающихся на четную цифру*/

void CubsEndEven(int number)
{
    for (int i = 2; i <= number; i++)
    if ((Math.Pow(i, 3)) % 2 == 0)
    {
        Console.WriteLine($"Cub of {i} is {Math.Pow(i, 3)} and ended on even digit");
    }
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

CubsEndEven(number);