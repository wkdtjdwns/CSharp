int cnt1 = 0;
int cnt2 = 0;
int MatrixPathRec(int[,] m, int i, int j)
{
    if (i == 0 || j == 0)
    {
        cnt1++;
        return 0;
    }

    else
    {
        return m[i, j] + Math.Max(MatrixPathRec(m, i - 1, j), MatrixPathRec(m, i, j - 1));
    }
}

int MatrixPathDP(int[,] m, int n)
{
    int[,] d = new int[16, 16];

    for (int i = 0; i <= n; i++)
    {
        d[i, 0] = 0;
    }

    for (int j = 1; j <= n; j++)
    {
        d[0, j] = 0;
    }

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            cnt2++;
            d[i, j] = m[i, j] + Math.Max(d[i - 1, j], d[i, j - 1]);
        }
    }

    return d[n, n];
}

int n = int.Parse(Console.ReadLine());
int[,] m = new int[16, 16];
for (int i = 1; i <= n; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    for (int j = 1; j <= n; j++)
    {
        m[i, j] = int.Parse(input[j - 1]);
    }
}

MatrixPathDP(m, n);
MatrixPathRec(m, n, n);

Console.WriteLine($"{cnt1} {cnt2}");
