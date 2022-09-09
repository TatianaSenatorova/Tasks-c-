/*Определить количество цифр в числе*/

int NumDigits(int number)
{
    int count = 1;
    while (number / 10 != 0)
    {
        number /= 10;
        count += 1;
    }
    return count;
}

Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.Write(NumDigits(number));