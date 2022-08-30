/*По двум заданным числам проверять является ли одно квадратом другого*/

void NumsSquare(int first, int second)
{
    if (first * first == second || second * second == first)
    Console.Write($"Yes, one number is a square of another");
    else Console.Write($"No, one number isn't a square of another");
}
Console.WriteLine("Enter a first number: ");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a second number: ");
int second = int.Parse(Console.ReadLine());

NumsSquare(first, second);

