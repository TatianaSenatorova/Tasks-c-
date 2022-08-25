/*По заданному номеру дня недели вывести его название*/

void DayWeek(int day)
{
    if (day == 1) Console.Write($"Mondey ");
    else if (day == 2) Console.Write($"Tuesday  ");
    else if (day == 3) Console.Write($"Wednesday   ");
    else if (day == 4) Console.Write($"Thursday   ");
    else if (day == 5) Console.Write($"Friday   ");
    else if (day == 6) Console.Write($"Saturday   ");
    else if (day == 7) Console.Write($"Sunday   ");
    else Console.Write($"You enter wrong number   ");
}
Console.Write("Enter number of day: ");
int day = int.Parse(Console.ReadLine());

DayWeek(day);
