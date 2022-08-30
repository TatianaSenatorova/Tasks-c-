/*Дано число обозначающее день недели. Выяснить является номер дня недели выходным */

void WeekEnd(int numDay)
{
    if (numDay == 6 || numDay == 7)
    Console.Write($"{numDay} is a weekend day");
    else  if (numDay > 0 && numDay < 6) Console.Write($"{numDay} isn't a weekend day");
    else Console.Write($"You enter wrong day. Try again");
}
Console.WriteLine("Enter a number of the week day: ");
int numDay = int.Parse(Console.ReadLine());
WeekEnd(numDay);