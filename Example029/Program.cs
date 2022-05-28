// 1. Напишите программу, которая перевернёт одномерный массив
//   (последний элемент будет на первом месте, а первый - на последнем и т.д.) 


// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] MassNums(int size, int from, int to)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(from, to);
//     }
//     return arr;
// }

// int[] RevMas(int[] arr)
// {
//     int size = arr.Length - 1;
    
//     for (int i = 0; i < size / 2 + 1; i++)
//     {
//         (arr[i], arr[size - i]) = (arr[size - i], arr[i]);
//     }
//     return arr;
// }

// int[] arr_1 = MassNums(8, 5, 21);
// Print(arr_1);
// RevMas(arr_1);
// Print(arr_1);

// void Check(int a, int b, int c){
//     if(a+b>c && a+c>b && b+c>a) Console.WriteLine("Everything is correct");
//     else Console.WriteLine("Please check your values");
// }

// Check(4,2,5);


// void Something (int num)
// {
//     string i = " ";
//     while (num > 0)
//     {
//         i = num % 2 + i;
//         num = num / 2;
//     }
//     Console.Write(i);
// }
// Something(2);

void F(int num)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a,b) = (b,a+b);
    }
}

F(9);
