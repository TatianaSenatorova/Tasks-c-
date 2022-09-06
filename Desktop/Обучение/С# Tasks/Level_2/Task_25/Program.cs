/*Найти сумму чисел от 1 до А*/

int SumNumbers(int A)
{
    int result = 0;
    for (int i = 1; i <= A; i++)
    result += i;
    return result;
}
Console.WriteLine("Enter a number A: ");
int A = int.Parse(Console.ReadLine());

Console.Write(SumNumbers(A));