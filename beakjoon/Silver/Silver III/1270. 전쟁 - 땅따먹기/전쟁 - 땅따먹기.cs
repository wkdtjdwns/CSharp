int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Dictionary<long, int> armys = new Dictionary<long, int>();

    string[] ti = Console.ReadLine().Split(" ");
    int t = int.Parse(ti[0]);

    int max = 0;
    long result = 0;
    for (int j = 1; j <= t; j++)
    {
        long index = long.Parse(ti[j]);
        if (armys.ContainsKey(index))
        {
            armys[index] += 1;
        }

        else
        {
            armys[index] = 1;
        }

        if (armys[index] > max)
        {
            max = armys[index];
            result = index;
        }
    }

    if (max > (t / 2))
    {
        Console.WriteLine(result);
    }

    else
    {
        Console.WriteLine("SYJKGW");
    }
}
