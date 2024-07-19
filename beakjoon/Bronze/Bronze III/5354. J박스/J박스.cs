int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            if (j == 0 || j == n - 1 || k == 0 || k == n - 1)
            {
                Console.Write("#");
            }

            else
            {
                Console.Write("J");
            }
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}
