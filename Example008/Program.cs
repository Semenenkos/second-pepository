int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15151;
int b1 = 21;
int c1 = 3963;
int a2 = 12;
int b2 = 2314;
int c2 = 33;
int a3 = 13;
int b3 = 2345;
int c3 = 312;

//Это длинный путь:
//int max1 = Max(a1, b1, c1);

//Console.Write("Max 1 = ");
//Console.WriteLine(max1);

//int max2 = Max(a2, b2, c2);

//Console.Write("Max 2 = ");
//Console.WriteLine(max2);

//int max3 = Max(a3, b3, c3);

//Console.Write("Max 3 = ");
//Console.WriteLine(max3);

//А можно то же, но одной строкой:

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.Write("Max = ");
Console.WriteLine(max);