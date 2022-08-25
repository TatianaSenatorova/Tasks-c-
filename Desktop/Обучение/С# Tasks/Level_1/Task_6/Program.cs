/*Выяснить является ли число чётным*/

void EvenNum(int number)
{
    if (number % 2 == 0) Console.Write($"{number} is an even number");
    else Console.Write($"{number} isn't an even number");
}
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
EvenNum(number);