/*Задать номер четверти, показать диапазоны для возможных координат*/

void Coordinates(int numQuaterCoordinates)
{
    if (numQuaterCoordinates == 1)
    Console.Write($"x > 0 and y > 0");
    else if (numQuaterCoordinates == 2)
    Console.Write($"x < 0 and y > 0");
    else if (numQuaterCoordinates == 3)
    Console.Write($"x < 0 and y < 0");
    else if (numQuaterCoordinates == 4)
    Console.Write($"x > 0 and y < 0");
    else Console.Write($"You write wrong number. Try again");

}
Console.WriteLine("Enter number of coordinates quater: ");
int numQuaterCoordinates = int.Parse(Console.ReadLine());


Coordinates(numQuaterCoordinates);
