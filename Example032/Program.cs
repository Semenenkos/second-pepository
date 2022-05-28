// Домашнее задание к семинару 4.

// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int NumPow (int A, int B)
{
    int natpow = A;
    for (int i = 1; i < B; i++)
    {
        natpow *= A;
    }
    return natpow;
}
Console.WriteLine(NumPow(2, 5));
Console.WriteLine(NumPow(3, 6));
Console.WriteLine();

// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sumdigit (int num)
{
    int natsum = 0;
    while (num > 0)
    {
        natsum += num % 10;
        num /= 10;
    }
    return natsum;
}
Console.WriteLine(Sumdigit(285));
Console.WriteLine(Sumdigit(840));
Console.WriteLine();

// 3. Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//    Оформите заполнение массива и вывод в виде функции.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] Array_of_eight_numbers()
{   
    int size = 8;

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);        
    }    
    return arr;
}

int[] arr_1 = Array_of_eight_numbers();
Print(arr_1);
int[] arr_2 = Array_of_eight_numbers();
Print(arr_2);
