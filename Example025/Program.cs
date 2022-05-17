// Метод 1 (ничего не возвращает и ничего не принимает)
void Method1()
{
    Console.WriteLine("Это я сделяль");
}
Method1(); // <--- так метод вызывается

// Метод 2 (ничего не возвращает, но что-то принимает)
void Method2(string s_a)
{
    Console.WriteLine(s_a);
}
Method2("Вот такой вот метод 2");

// Метод 2.1 (в случае если мы хотим указать конкретное значение - конкретному аргументу)
void Method2_1(string s_a, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(s_a);
        i++; // инкремент - увеличение на 1, уменьшение на 1 - декремент
    }
}
Method2_1("Вот такой вот метод 2_1", 2);

// Метод 3 (что-то возвращает, но ничего не принимает)
int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year);

// Метод 4 (что-то возвращает, что-то принимает)
string Method4(int count, string s)
{
    int i = 0;
    string result = string.Empty; // пустая строка
    while (i < count)
    {
      result = result + s;
      i++;
    }
    return result;
}
string res = Method4(3, "Вот такой вот метод 4, "); // создаем переменную, чтобы вызвать метод
Console.WriteLine(res);
