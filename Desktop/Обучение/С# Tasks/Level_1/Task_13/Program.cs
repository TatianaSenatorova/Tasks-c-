/*Выяснить, кратно ли число заданному, если нет, вывести остаток*/

void Multiple(int first_number, int second_number)
{
    int remainderDivision = 0;
    if (first_number % second_number == 0) Console.Write($"{first_number} is multiple {second_number}");
    else Console.Write($"{first_number} isn't multiple {second_number}. The remainder ot the division is {remainderDivision}"); 
}

Console.WriteLine("Enter first number: ");
int first_number = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number (not zero): ");
int second_number = int.Parse(Console.ReadLine());

Multiple(first_number, second_number);
