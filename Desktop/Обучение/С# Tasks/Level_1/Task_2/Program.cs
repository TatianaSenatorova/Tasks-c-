/*По двум заданным числам проверять является ли первое квадратом второго*/

void NumsSquare(int firstNum, int secondNum)
{
    if (secondNum * secondNum == firstNum)
    Console.Write($"Yes, {secondNum} * {secondNum} = {firstNum}");
    else Console.Write($"No, {secondNum} * {secondNum} != {firstNum}");
}

Console.Write("Enter a first number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Enter a second number: ");
int secondNum = int.Parse(Console.ReadLine());

NumsSquare(firstNum, secondNum);