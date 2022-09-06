/*Найти расстояние между точками в пространстве 2D/3D*/

double DistanceBetweenPoints(int X1, int Y1, int X2, int Y2)
{
    double result = 0;
    result = Math.Round(Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)), 2);
    return result;
}

Console.WriteLine("Enter X1 of a first point: ");
int X1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y1 of a first point: ");
int Y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter X2 of a second point: ");
int X2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y2 of a second point: ");
int Y2 = int.Parse(Console.ReadLine());


Console.Write(DistanceBetweenPoints(X1, Y1, X2, Y2));