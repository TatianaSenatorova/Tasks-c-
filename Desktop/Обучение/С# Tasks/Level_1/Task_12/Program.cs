/*Удалить вторую цифру трёхзначного числа*/
 int DelMidleDigit(int number)
 {
    int twoDigitNum = ((number / 100) % 10) * 10 + number % 10;
    return twoDigitNum;
 }

 Console.WriteLine("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"Number without middle digit is {DelMidleDigit(number)}");