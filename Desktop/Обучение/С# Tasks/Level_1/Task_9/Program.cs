/*Показать последнюю цифру трёхзначного числа*/

int LastNumber(int number)
{
   number = number % 10;
   return number;
}
Console.WriteLine("Enter a number: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"Last number is {LastNumber(number)}");