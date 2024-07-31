string str = Console.ReadLine();
for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - i - 1])
    {
        Console.WriteLine(0);
        return;
    }
}

Console.WriteLine(1);
