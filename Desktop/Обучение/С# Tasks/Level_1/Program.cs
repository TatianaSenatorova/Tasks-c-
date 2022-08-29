/*Найти третью цифру числа или сообщить, что её нет*/

void ThirdDigit(int number)
{
    while (number % 1000 == 0)
    {
        number /=  10;
    }
    if (number % 100 == 0) Console.Write($"There isn't third digit in number");
    else Console.Write($" {number % 100} third digit in number");
}
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());
ThirdDigit(number);
