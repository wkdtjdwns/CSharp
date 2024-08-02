int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] dnsp = Console.ReadLine().Split(" ");
    int d = int.Parse(dnsp[0]);
    int n = int.Parse(dnsp[1]);
    int s = int.Parse(dnsp[2]);
    int p = int.Parse(dnsp[3]);

    if (d + p * n == n * s)
    {
        Console.WriteLine("does not matter");
    }

    else if (d + p * n > n * s)
    {
        Console.WriteLine("do not parallelize");
    }

    else
    {
        Console.WriteLine("parallelize");
    }
}
