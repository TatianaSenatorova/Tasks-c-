/*Даны два числа. Показать большее и меньшее число*/
int MaxNum(int firstNum, int secondNum)
{
    if (firstNum > secondNum) return firstNum;
    else return secondNum;
}

Console.Write("Enter a first number: ");
int firstNum = int.Parse(Console.ReadLine());
Console.Write("Enter a second number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.Write($"Larger number → {MaxNum(firstNum, secondNum)}");