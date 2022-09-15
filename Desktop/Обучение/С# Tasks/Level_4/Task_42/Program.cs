/*Определить сколько чисел больше 0 введено с клавиатуры*/

void PositiveNums(string [] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
       int num = int.Parse(numbers[i]);
       if (num > 0)
       count += 1;
    }
    Console.WriteLine($"Positive numbers in mass {count}");
}

Console.WriteLine("Enter several number divided by space: ");
string s = Console.ReadLine();
string[] numbers = s.Split(' ');
PositiveNums(numbers);

