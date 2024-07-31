int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = n; j > i; j--)
    {
        Console.Write(" ");
    }

    if (i == n)
    {
        for (int j = 0; j < 2 * i - 1; j++)
        {
            Console.Write("*");
        }
    }

    else
    {
        for (int j = 0; j < 2 * i - 1; j++)
        {
            if (j == 0 || j == 2 * i - 1 - 1)
            {
                Console.Write("*");
            }

            else
            {
                Console.Write(" ");
            }
        }
    }

    Console.WriteLine();
}
