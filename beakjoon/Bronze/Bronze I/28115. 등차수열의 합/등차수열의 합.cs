int n = int.Parse(Console.ReadLine());
string[] aValues = Console.ReadLine().Split(" ");
long[] a = new long[n];
for (int i = 0; i < n; i++)
{
    a[i] = long.Parse(aValues[i]);
}

if (n == 1)
{
    Console.WriteLine("YES");
    Console.WriteLine($"{a[0] / 2 * 2}");
    Console.WriteLine($"{a[0] - (a[0] / 2 * 2)}");
    return;
}

bool check = true;
for (int i = 2; i < n; i++)
{
    if (a[i] - a[i - 1] != a[i - 1] - a[i - 2])
    {
        check = false;
    }
}

if (check)
{
    Console.WriteLine("YES");
    long[] b = new long[n];
    long[] c = new long[n];
    for (int i = 0; i < n; i++)
    {
        b[i] = a[i] + i;
        c[i] = -i;
    }

    Console.WriteLine(string.Join(" ", b));
    Console.WriteLine(string.Join(" ", c));
}

else
{
    Console.WriteLine("NO");
}
