int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    if (i % 2 == 1)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < n; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}
