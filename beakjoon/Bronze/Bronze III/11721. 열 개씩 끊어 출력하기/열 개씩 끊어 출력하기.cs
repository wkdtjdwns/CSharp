string str = Console.ReadLine();
for (int i = 0; i < str.Length; i++)
{
    if (i % 10 == 0 && i != 0)
    {
        Console.WriteLine();
    }

    Console.Write(str[i]);
}
