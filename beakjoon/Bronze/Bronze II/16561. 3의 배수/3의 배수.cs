int n = int.Parse(Console.ReadLine()) / 3;
int cnt = 0;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n - i; j++)
    {
        if (n - i - j > 0) { cnt++; }
    }
}

Console.WriteLine(cnt);
