//Программа, принимающая на вход два числа и дающая проверить: является ли первое число, квадратом второго.

string s_a = Console.ReadLine();
string s_b = Console.ReadLine();
int a = int.Parse(s_a); 
int b = int.Parse(s_b);
if (b == a * a)
{
    Console.WriteLine ("Yes");
}
else
{
    Console.WriteLine ("No");
}
