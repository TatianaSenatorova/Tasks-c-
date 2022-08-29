/*Дано число. Проверить кратно ли оно 7 и 23*/

void Multiple(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    Console.Write($"{number} is multiple to 7 and 23");
    else Console.Write($"{number} isn't multiple 7 and 23");
}
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
Multiple(number);