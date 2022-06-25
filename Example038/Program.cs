// 1. Задайте значения M и N. 
//    Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.


void AllEvenNaturalNumbers(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 1) M += 1;

    Console.Write($"{M}, ");
    AllEvenNaturalNumbers(M + 2, N);    
}

AllEvenNaturalNumbers(1, 5);
Console.WriteLine();
AllEvenNaturalNumbers(4, 8);
Console.WriteLine();

// 2. Задайте значения M и N. 
//    Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumOfNaturalElements(int M, int N)
{
    if (M > N) return 0;    
    return SumOfNaturalElements(M, N - 1) + N;
}

Console.WriteLine(SumOfNaturalElements(1, 15));
Console.WriteLine(SumOfNaturalElements(4, 8));