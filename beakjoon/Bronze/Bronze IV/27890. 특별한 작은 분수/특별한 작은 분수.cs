string[] xn = Console.ReadLine().Split(" ");
int x = int.Parse(xn[0]);
int n = int.Parse(xn[1]);

for (int i = 0; i < n; i++)
{
    if (x % 2 == 0)
    {
        x /= 2;
    }

    else
    {
        x *= 2;
    }

    x ^= 6;
}

Console.WriteLine(x);
