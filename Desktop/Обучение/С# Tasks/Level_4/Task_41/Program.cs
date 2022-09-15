/*Выяснить являются ли три числа сторонами треугольника */

void IfTriangle(int firstNumber, int secondNumber, int thirdNumber)
{
    if (firstNumber + secondNumber > thirdNumber && secondNumber + thirdNumber > firstNumber && firstNumber + thirdNumber > secondNumber)
    Console.Write($"These numbers could be lengths of a triangle ");
    else Console.Write($"These numbers couldn't be lengths of a triangle ");
}

Console.WriteLine("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int thirdNumber = int.Parse(Console.ReadLine());

IfTriangle(firstNumber, secondNumber, thirdNumber);