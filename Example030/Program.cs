// Домашнее задание к семинару 2.

// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Secdigit (int num)
{
    return num / 10 % 10;
}

Console.WriteLine($"The second digit of this number -> {Secdigit(582)}");
Console.WriteLine();

// 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

void Threedigitnumrandom()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num} -> {num /100}{num % 10}");
}
Threedigitnumrandom();
Console.WriteLine();

// 3. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Thirddigitnum(int num)
{
    Console.Write($"{num} -> The third digit is -> ");
    int third_num = 0;
    string txt;

    while (num > 99)
    {
        third_num = num % 10;
        num = num / 10;
    }
    txt = $"{third_num}";
    if (third_num == 0)
    {
        txt = "It's not a three-digit number";
    }
    Console.WriteLine(txt);
}

Thirddigitnum(258);
Thirddigitnum(32627);
Thirddigitnum(50);
Console.WriteLine();

// 4. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "It's a weekday";
    if (num == 7 || num == 6)
    {
        text = "It's a weekend";
    }
    Console.WriteLine($"{num} -> {text}");
}

Weekend(5);
Weekend(7);
Weekend(3);
Weekend(6);
Weekend(4);