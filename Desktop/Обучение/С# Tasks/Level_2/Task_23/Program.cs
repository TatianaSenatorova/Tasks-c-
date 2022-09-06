/*Показать таблицу квадратов чисел от 1 до N */

void SquareNumber(int number)
{
    for (int i = 0; i <= number; i++)
    Console.Write($"{Math.Pow(i, 2)}, ");
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());


SquareNumber(number);