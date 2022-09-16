/*Написать программу преобразования десятичного числа в двоичное*/

int FromDecimalToBinary(int number)
{
    string num = string.Empty;
    while (number / 2 > 0)
    {
        int n = number % 2;
        num = n + num;
        number /= 2;
    }
    if (number % 2 > 0)
    {
        int n = number % 2;
        num = n + num;
    }

    int binaryNum = int.Parse(num);
    return binaryNum;
}

Console.WriteLine("Enter any decimal number: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"Number {number} in binery system " + FromDecimalToBinary(number));
