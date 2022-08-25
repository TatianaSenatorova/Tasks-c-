/*Показать числа от -N до N*/

void rowNumbers(int number)
{
    if (number > 0)
    for(int i = - number; i <= number; i++)
    Console.Write($"{i},  ");
    else for (int i = - number; i >= number; i--)
    Console.Write($"{i},  ");
  }

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

rowNumbers(number);