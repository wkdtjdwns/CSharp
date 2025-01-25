int n = int.Parse(Console.ReadLine());
if (n == 0 || n == 2)
{
    Console.WriteLine("NO");
    return;
}

while (n / 3 > 0)
{
    if (n % 3 == 2)
    {
        Console.WriteLine("NO");
        return;
    }

    n /= 3;
}

if (n % 3 == 2)
{
    Console.WriteLine("NO");
}

else
{
    Console.WriteLine("YES");
}
