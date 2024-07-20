int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int max = m;

for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    m += a;
    m -= b;
    max = Math.Max(max, m);
    if (m < 0)
    {
        max = 0;
        break;
    }
}

Console.WriteLine(max);
