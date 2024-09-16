int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int m = int.Parse(Console.ReadLine());
    long result = 0;
    long[] kArray = new long[m];
    long[] dArray = new long[m];
    long[] aArray = new long[m];

    for (int j = 0; j < m; j++)
    {
        string[] a1 = Console.ReadLine().Split(" ");
        kArray[j] = long.Parse(a1[0]);
        dArray[j] = long.Parse(a1[1]);
        aArray[j] = long.Parse(a1[2]);
    }

    string[] a2 = Console.ReadLine().Split(" ");
    long k = long.Parse(a2[0]);
    long d = long.Parse(a2[1]);
    long a = long.Parse(a2[2]);

    for (int j = 0; j < m; j++)
    {
        long total = (kArray[j] * k) - (dArray[j] * d) + (aArray[j] * a);

        if (total > 0)
        {
            result += total;
        }
    }

    Console.WriteLine(result);
}
