/*Определить номер четверти плоскости,
в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0*/

void QuaterCoordinate(int x, int y)
{
    if (x > 0 && y > 0)
    Console.Write($"First quater of coordinates ");
    else if (x < 0 && y > 0)
    Console.Write($"Second quater of coordinates ");
    else if (x < 0 && y < 0)
    Console.Write($"Third quater of coordinates ");
    else if (x > 0 && y < 0)
    Console.Write($"Fourth quater of coordinates ");
}
Console.WriteLine("Enter X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y: ");
int y = int.Parse(Console.ReadLine());

QuaterCoordinate(x, y);