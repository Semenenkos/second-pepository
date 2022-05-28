// Домашнее задание к семинару 5.

// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//    Напишите программу, которая покажет количество чётных чисел в массиве. 

// void Print(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] Array_of_random_positive_three_digit_numbers (int size, int from, int to)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(from, to);
//     }
//     return arr;
// }

// int Even_Numbers (int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             count += 1;
//         }        
//     }
//     return count;
// }

// int[] arr_1 = Array_of_random_positive_three_digit_numbers (11, 100, 501);
// Print(arr_1);
// Console.WriteLine(Even_Numbers(arr_1));
// int[] arr_2 = Array_of_random_positive_three_digit_numbers (8, 100, 251);
// Print(arr_2);
// Console.WriteLine(Even_Numbers(arr_2));
// Console.WriteLine();

// 2. Задайте одномерный массив, заполненный случайными числами. 
//    Найдите сумму элементов, стоящих на нечётных позициях.

// void Print(int[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] One_dimensional_array_with_random_numbers (int size, int from, int to)
// {
//     int[] arr = new int[size];
//     for (int i = 1; i < size; i++)
//     {
//         arr[i] = new Random().Next(from, to);
//     }
//     return arr;
// }

// int Sum_of_elements_in_odd_positions (int[] arr)
// {
//     int count = 0;
//     for (int i = 1; i < arr.Length; i += 2)
//     {
//         count += arr[i];
//     }
//     return count;
// }

// int[] arr_1 = One_dimensional_array_with_random_numbers (8, 1, 11);
// Print(arr_1);
// Console.WriteLine(Sum_of_elements_in_odd_positions (arr_1));
// int[] arr_2 = One_dimensional_array_with_random_numbers (5, 1, 15);
// Print(arr_2);
// Console.WriteLine(Sum_of_elements_in_odd_positions (arr_2));
// Console.WriteLine();

// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// void Print(double[] arr)
// {
//     int size = arr.Length;
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// double[] ArrayRealNumbers(int size)
// {
//     double[] arr = new double[size];
//     Random n_new = new Random();
//     for (int i = 1; i < size; i++)
//     {
//         arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
//     }
//     return arr;
// }

// void DiffMaxMinValues(double[] arr)
// {
//     double n_max = arr[0];
//     double n_min = arr[0];

//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (n_max < arr[i])
//         {
//             n_max = arr[i];
//         }
//         else if (n_min > arr[i])
//         {
//             n_min = arr[i];
//         }
//     }
//     Console.Write($"Max: {n_max}, min: {n_min}. ");
//     Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
// }

// double[] arr_1 = ArrayRealNumbers(8);
// Print(arr_1);
// DiffMaxMinValues(arr_1);

// double[] arr_2 = ArrayRealNumbers(5);
// Print(arr_2);
// DiffMaxMinValues(arr_2);

// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//    Результат запишите в новом массиве. 

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] Product_Numbers(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 11);
    }
    return arr;
}

int[] Pair_Numbers(int[] arr)
{
    int size = arr.Length;
    int[] new_arr = new int[size / 2];
    if (size % 2 == 1)
    {
        new_arr = new int[size / 2 + 1];
        new_arr[new_arr.Length - 1] = arr[size / 2];
    }

    for (int i = 0; i < size / 2; i++)
    {
        new_arr[i] = arr[i] * arr[size - i - 1];
    }

    return new_arr;
}
int[] arr_1 = Product_Numbers(5);
Print(arr_1);
int[] arr_1_new = Pair_Numbers(arr_1);
Print(arr_1_new);
int[] arr_2 = Product_Numbers(8);
Print(arr_2);
int[] arr_2_new = Pair_Numbers(arr_2);
Print(arr_2_new);