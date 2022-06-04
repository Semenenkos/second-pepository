// Домашнее задание к семинару 6

// 1. Пользователь вводит с клавиатуры M чисел. 
//    Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountNum()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.Write("Numbers greater than zero: ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) > 0) count += 1;        
    }
}

Console.Write(CountNum());

Console.WriteLine();

// 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//    y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Intersection point: ({x}; {y})");
}

IntersectionPoint(2, 5, 1, 3);
Console.WriteLine();

// 3. Напишите программу, которая будет создавать копию заданного 2-мерного массива с помощью поэлементного копирования.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;
}

int[,] CopyMass(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];
    
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            new_arr[i, j] = arr[i, j];
        }        
    }
    return new_arr;
}

int[,] arr_1 = MassNums(3, 2, 6, 8);
Print(arr_1);
int[,] arr_1_new = CopyMass(arr_1);
Print(arr_1_new);

int[,] arr_2 = MassNums(2, 5, 11, 24);
Print(arr_2);
int[,] arr_2_new = CopyMass(arr_2);
Print(arr_2_new);