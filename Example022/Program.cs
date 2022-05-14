//Домашнее задание. Семинар 1. Задача 6.
//Программа, которая на вход принимает значение, а на выходе показывает обратное значение.

string s_a = Console.ReadLine();
double a = double.Parse(s_a);
if (a > 0)
{
     a = 1 / a;
}
Console.WriteLine (a);