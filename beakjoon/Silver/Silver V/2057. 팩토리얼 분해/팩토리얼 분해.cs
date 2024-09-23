long n = long.Parse(Console.ReadLine());
long[] a = new long[21];
if (n == 0)
{
    Console.WriteLine("NO");
    return;
}

a[0] = 1L;
for (int i = 1; i < 21; i++)
{
    a[i] = a[i - 1] * i;
}

for (int i = 20; i >= 0; i--)
{
    if (n >= a[i])
    {
        n -= a[i];
    }
}

if (n == 0)
{
    Console.WriteLine("YES");
}

else
{
    Console.WriteLine("NO");
}
