Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "носик")
{
    Console.WriteLine("Ой, это кито? Это зи, мой любимый носик");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine (username);
}