/*Написать программу вычисления произведения чисел от 1 до N*/

int Multiply(int number)
{
    int multiplyNums = 1;
    for (int i = 2; i <= number; i++)
    {
        multiplyNums *= i;
    }
return multiplyNums;
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.Write(Multiply(number));