/*Дано число из отрезка [10, 99]. Показать наибольшую цифру числа*/

int MaxDigit(int number)
{
    int max;
    if(number / 10 % 10 > number % 10)
    max = number / 10 % 10;
    else max = number % 10;
    return max;
}

Console.WriteLine("Enter a two-digit number: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"Maximum digit in number is {MaxDigit(number)}");