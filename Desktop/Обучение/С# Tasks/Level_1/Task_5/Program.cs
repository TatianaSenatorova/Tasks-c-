/*Найти максимальное из трех чисел*/

int MaxNum(int first, int second, int third)
{
    int max;
    if(first >  second)  max = first;
    else max = second;
    if (max < third) max = third;
    return max;
}
Console.Write("Enter a first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter a second number: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter a second number: ");
int third = int.Parse(Console.ReadLine());


Console.Write($"{MaxNum(first, second, third)} ");