//Домашнее задание. Семинар 1. Задача 5.
//Программа вычисления модуля числа.

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
if (a < 0)
{
    a = a * -1;
}
Console.WriteLine (a);