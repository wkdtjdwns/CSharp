int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = n - 1; j > i; j--)
    {
        Console.Write(" ");
    }

    Console.Write("*");
    for (int j = 0; j < 2 * i - 1; j++)
    {
        Console.Write(" ");
    }

    if (i > 0)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
