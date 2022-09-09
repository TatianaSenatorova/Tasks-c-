/*Подсчитать сумму цифр в числе*/

int SumDigits(int number)
{
    int sum = 0;
    while(number % 10 != 0)
    {
       sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.Write(SumDigits(number));