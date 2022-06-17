// Домашнее задание к семинару 8

// 1. Задайте двумерный массив. 
//    Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Print(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i = 0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($" {arr[i, j],3} ");
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

void DescendingOrder(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i = 0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
        {
            for (int k = 0; k < columns_size - j - 1; k++)
                if (arr[i, k] < arr[i, k + 1])
                   (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
        }
    }
}
Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());
int[,] arr_1 = TwoDimensionalArray(rows, columns, 0, 10);
Print(arr_1);
DescendingOrder(arr_1);
Print(arr_1);

// 2. Задайте прямоугольный двумерный массив. 
//    Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i = 0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] RectangularTwoDimensionalArray(int rows, int columns, int from, int to)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void RowWithTheSmallestAmountOfElements(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    int amount = 1000;
    int num;
    int smallest = 0;
    for (int i = 0; i < rows_size; i++)
    {   
        num = 0;
        for (int j = 0; j < columns_size; j++)
            num += arr[i, j];
        if (amount > num)
        {
            amount = num;
            smallest = i;
        }
    }
    Console.Write($"The row with the smallest amount of elements - {smallest + 1}");
}

Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());
int[,] arr_1 = RectangularTwoDimensionalArray(rows, columns, 0, 10);
Print(arr_1);
RowWithTheSmallestAmountOfElements(arr_1);

// 3. Задайте две матрицы. 
//    Напишите программу, которая будет находить произведение двух матриц.

void Print(int[,] arr)
{
    int rows_size = arr.GetLength(0);
    int columns_size = arr.GetLength(1);
    for (int i = 0; i < rows_size; i++)
    {
        for (int j = 0; j < columns_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] TwoGivenMatrices(int rows, int columns, int from, int to)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] ProductOfTwoMatrices(int[,] arr_first, int[,] arr_second)
{
    int rows_size = arr_first.GetLength(0);
    int columns_size = arr_first.GetLength(1);
    int[,] ProductOfTwoMatrices = new int[rows_size, columns_size];
    for (int i = 0; i < rows_size; i++)       
        for (int j = 0; j < columns_size; j++)
            ProductOfTwoMatrices[i, j] = arr_first[i, j] * arr_second[i, j];            
    return ProductOfTwoMatrices;
}

Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());
int[,] arr_1 = TwoGivenMatrices(rows, columns, 0, 5);
Print(arr_1);
int[,] arr_2 = TwoGivenMatrices(rows, columns, 0, 5);
Print(arr_2);
int[,] result = ProductOfTwoMatrices(arr_1, arr_2);
Print(result);