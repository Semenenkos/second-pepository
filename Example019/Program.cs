//Домашнее задание. Семинар 1. Задача 3.

string s_a = Console.ReadLine();

int a = int.Parse(s_a);

if (a % 2 == 0)
{
    Console.Write($"{a} is even");
}
else
{
    Console.Write($"{a} is odd");
}