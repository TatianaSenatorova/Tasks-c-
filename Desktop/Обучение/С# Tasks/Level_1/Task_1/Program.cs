/*Вывести квадрат числа*/

/*int Square(int a)
{
 a *= a;
 return a;
}
Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());

Console.Write(Square(a));*/

double Square(int a)
{
    double numSquare = Math.Pow(a, 2);
    return numSquare;
}
Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());

Console.Write(Square(a));