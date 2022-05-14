//Домашнее задание. Семинар 1. Задача 1.

string s_a = Console.ReadLine();
string s_b = Console.ReadLine();
int a = int.Parse(s_a);
int b = int.Parse(s_b);
if (a > b)
{
    Console.Write ($"{a} is greater than {b} ");
}
else if (a == b)
{
    Console.Write ($"{a} is equal to {b} ");
}
else
{
    Console.Write ($"{b} is greater than {a} ");
}