/*Найти точку пересечения двух прямых заданных уравнением
y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы*/

void IntersectionPoint(int b1, int k1, int b2, int k2)
{
    int y = (b2 - (b1 * k2 / k1) / (1 - k2 / k1));
    int x = (y - b1) / k1;
    Console.WriteLine($"{x}");
     Console.Write($"{y}");
}

Console.WriteLine("Enter a coefficient b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a coefficient k1: ");
int k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a coefficient b2: ");
int b2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a coefficient k2: ");
int k2 = int.Parse(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);