int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string str = Console.ReadLine();
    if (str.Length % 2 == 0)
    {
        for (int j = 0; j < str.Length; j += 2) { Console.Write(str[j]); }
        Console.WriteLine();
        for (int j = 1; j < str.Length; j += 2) { Console.Write(str[j]); }
    }

    else
    {
        for (int j = 0; j < str.Length; j += 2) { Console.Write(str[j]); }
        for (int j = 1; j < str.Length; j += 2) { Console.Write(str[j]); }
        Console.WriteLine();
        for (int j = 1; j < str.Length; j += 2) { Console.Write(str[j]); }
        for (int j = 0; j < str.Length; j += 2) { Console.Write(str[j]); }
    }

    Console.WriteLine();
}
