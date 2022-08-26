/*Показать вторую цифру трёхзначного числа*/

int MiddleNum(int number)
{
    number /= 10;
    number = number % 10;
    return number;
}

Console.WriteLine("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"Middle number is {MiddleNum(number)}");