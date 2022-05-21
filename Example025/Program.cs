// Метод 1 (ничего не возвращает и ничего не принимает)
// void Method1()
// {
//     Console.WriteLine("Это я сделяль");
// }
// Method1(); // <--- так метод вызывается

// Метод 2 (ничего не возвращает, но что-то принимает)
// void Method2(string s_a)
// {
//     Console.WriteLine(s_a);
// }
// Method2("Вот такой вот метод 2");

// // Метод 2.1 (в случае если мы хотим указать конкретное значение - конкретному аргументу)
// void Method2_1(string s_a, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(s_a);
//         i++; // инкремент - увеличение на 1, уменьшение на 1 - декремент
//     }
// }
// Method2_1("Вот такой вот метод 2_1", 2);

// // Метод 3 (что-то возвращает, но ничего не принимает)
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int Year = Method3();
// Console.WriteLine(Year);

// // Метод 4 (что-то возвращает, что-то принимает)
// string Method4(int count, string s)
// {
//     int i = 0;
//     string result = string.Empty; // пустая строка
//     while (i < count)
//     {
//       result = result + s;
//       i++;
//     }
//     return result;
// }
// string res = Method4(3, "Вот такой вот метод 4_1, "); // создаем переменную, чтобы вызвать метод
// Console.WriteLine(res);

// // То же применение Метода 4, только с циклом for 
// string Method4_1(int count, string s)
// {
//     string result = string.Empty; // пустая строка
//     for (int i = 0; i < count; i++)
//     {
//       result = result + s;
//     }
//     return result;
// }
// string res_1 = Method4_1(3, "Вот такой вот метод 4_1, "); // создаем переменную, чтобы вызвать метод
// Console.WriteLine(res_1);

// //Демонстрация цикла в цикле (создание пародии на таблицу умножения)
// for (int i = 2; i <= 10; i++)
// {
//    for (int j = 2; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i*j}");
//    }
//    Console.WriteLine();
// }

//Работа с текстом
//Дан текст. В нем нужно заменить: пробелы - чёрточками; 
// Маленькие буквы "к" - большими "К";
// а большие "С" - маленькими "с".

// string text = "Дорогой Карл Двенадцатый, сражение под Полтавой,"
//             + "слава Богу, проиграно. Как говорил картавый,"
//             + "время покажет кузькину мать, руины,"
//             + "кости посмертной радости с привкусом Украины.";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text [i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '_');
// Console.WriteLine();
// newText = Replace(text, 'о', 'О');
// Console.WriteLine();
// newText = Replace(text, 'П', 'п');
// Console.WriteLine(newText);

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
   int count = array.Length;

   for (int i = 0; i < count; i++)
   {
       Console.Write($"{array[i]} ");
   }
Console.WriteLine();
}

void SelectionSort(int[] array)
{
   for (int i = 0; i < array.Length - 1; i++)
   {
       int minPostition = i;
       for (int j = i + 1; j < array.Length; j++)
       {
          if (array[j] < array [minPostition]) minPostition = j;
       }
       int temporary = array[i]; 
       array[i] = array [minPostition];
       array [minPostition] = temporary;
   }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);