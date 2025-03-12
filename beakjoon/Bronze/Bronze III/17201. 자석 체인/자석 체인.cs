int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

for (int i = 0; i < str.Length - 1; i++)
{
    if ((str[i] == '1' && str[i + 1] == '1') ||
        (str[i] == '2' && str[i + 1] == '2'))
    {
        Console.WriteLine("No");
        return;
    }
}

Console.WriteLine("Yes");
