// Домашнее задание к семинару 3.

// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "It's a palindrome";
    while (i < size / 2)
    {
        if (num [i] != num [size-i])
        {
            flag = "It's not a palindrome";
            break;
        }
        i += 1; 
    }
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome (14212);
Palindrome (23432);
Palindrome (12821);
Palindrome (1245421);
Palindrome (12345678);
Palindrome (124585421);
Console.WriteLine();

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distancein3Dspace (float x1, float y1, float z1, float x2, float y2, float z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
}
Console.WriteLine(distancein3Dspace(2, 5, 8, -3, -4, 6));
Console.WriteLine(distancein3Dspace(3, 6, -5, -0, -1, 1));
Console.WriteLine();

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Squares(int n)
{
    double[] nums = new double[n];
    int index = 0;

    Console.Write($"{n} -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 3);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }    
    Console.WriteLine();
}

Squares(6);
Squares(2);
Squares(11);