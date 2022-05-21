//Задача 1
int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    {
        all_sum += i;
    }
    return all_sum;
}

Console.WriteLine(SumNum(7));

//Задача 2

void Sum(int num)
{
    int i = 0;
    while(num > 0){
        num = num / 10;
        i = i + 1;
    }
    Console.WriteLine(i);
}

Sum(1235);

//Задача 2.1
int NumCount(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(NumCount(456));
Console.WriteLine(NumCount(78));
Console.WriteLine(NumCount(89126));

//Задача 3
int PowNum(int num)
{
    int all_pow = 1;
    for (int i = 1; i <= num; i++)
    {
        all_pow *= i;
    }
    return all_pow;
}

Console.WriteLine(PowNum(5));

//Задача 4
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int [] array= new int[8];
for (int i = 0; i<8; i++){
    array[i] = new Random().Next(2);
    Console.Write(array[i]);
}
