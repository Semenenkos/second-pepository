// Метод со строками и столбцами
// string [,] table = new string [2, 5];
// table [1, 2] = "word";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// Метод с чисенными значениями
// int [,] matrix = new int [3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

//Метод вывода и заполнения числами двумерной матрицы
// void PrintArray (int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// } 

// void FillArray (int [,] matr)
// {
//    for (int i = 0; i < matr.GetLength(0); i++) // оператор для строк
//    {
//        for (int j = 0; j < matr.GetLength(1); j++) // оператор для столбцов
//        {
//            matr[i, j] = new Random().Next(1, 10);
//        }
//    } 
// }
// //                  [строки, столбцы]
// int [,] matrix = new int [3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// Вычисление факториала

// double Factorial (int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial (n-1);
// }
// for (int i = 1; i < 40; i++)
// Console.WriteLine($"{i}! = {Factorial(i)}");

// Последовательность Фибоначчи как рекурсия

double Fibonacci (int n)
{
    if (n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}