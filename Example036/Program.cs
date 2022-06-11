// Домашнее задание к семинару 7

// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j], 6} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] ArrayRealNumbers(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = Math.Round(n_new.NextDouble() * -10, 2);
        }
    }
    return arr;
}
double[,] arr_1 = ArrayRealNumbers(3, 4, -8, -9);
Print(arr_1);
double[,] arr_2 = ArrayRealNumbers(5, 6, -7, -10);
Print(arr_2);

// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//    и возвращает значение этого элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);

    for (int i = 0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] TwoDimensionalArray(int rows, int columns, int from, int to)
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

string ElementValue(int[,] arr, int k, int l)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    string text = "";

    if (k > rows || k <= 0 || l > columns || l <= 0)
        text = $"{k} {l} -> The element is missing in the array";

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            if (i + 1 == k && j + 1 == l)
            {
                text = $"arr[{k}, {l}] = {arr[i, j]} -> The element is contained in the array";
                break;
            }
    return text;
}

Console.Write("Enter the row position: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int second = int.Parse(Console.ReadLine());

int[,] arr_1 = TwoDimensionalArray(3, 4, 1, 11);
Print(arr_1);

Console.WriteLine(ElementValue(arr_1, first, second));

// 3. Задайте двумерный массив из целых чисел.
//    Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);

    for (int i = 0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] TwoDimensionalArray(int rows, int columns, int from, int to)
{
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void ArithmeticMean(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    double result;

    for (int i = 0; i < columns; i++)
    {
        result = 0;
        for (int j = 0; j < rows; j++) result += arr[j, i];
        Console.Write($"{Math.Round(result / rows, 1)}; ");
    }
}

Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] arr_1 = TwoDimensionalArray(rows, columns, 1, 6);
Print(arr_1);

ArithmeticMean(arr_1);