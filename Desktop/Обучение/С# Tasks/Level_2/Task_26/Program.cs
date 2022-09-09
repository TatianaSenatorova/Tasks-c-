/*Возведите число А в натуральную степень B используя цикл*/

int Exponentiation( int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    result = result * A;
    return result;
}

Console.WriteLine("Enter a number A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a degree raise: ");
int B = int.Parse(Console.ReadLine());

Console.Write(Exponentiation(A, B));