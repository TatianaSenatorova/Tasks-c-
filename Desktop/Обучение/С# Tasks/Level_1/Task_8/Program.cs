/*Показать четные числа от 1 до N*/

void EvenNumbers(int number)
{
    for (int i = 2; i <= number; i += 2)
    Console.Write($"{i}, ");
    
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

EvenNumbers(number);