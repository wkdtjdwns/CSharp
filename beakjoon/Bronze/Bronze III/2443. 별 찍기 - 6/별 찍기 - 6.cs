int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < (2 * n) - (2 * i) + 1; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
