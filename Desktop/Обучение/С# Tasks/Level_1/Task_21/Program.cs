/*Программа проверяет пятизначное число на палиндромом.*/

void Palindrome(int number)
{
    if (number / 10000 == number % 10 && (number / 10) % 10 == (number / 1000) % 10)
        Console.Write($"yes, it's a palindrome");
    else Console.Write($"no, it's not a palindrome");

}

Palindrome(12721);
