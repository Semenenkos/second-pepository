string s = Console.ReadLine();
int x = int.Parse(s);
int y = -x;
while (y <= x)
{
    Console.Write ($"{y} ");
    y = y + 1;
}