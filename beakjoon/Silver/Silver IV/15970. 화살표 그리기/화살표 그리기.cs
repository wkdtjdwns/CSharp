int n = int.Parse(Console.ReadLine());
List<List<int>> a = new List<List<int>>(n + 1);
for (int i = 0; i <= n; i++)
{
    a.Add(new List<int>());
}

for (int i = 0; i < n; i++)
{
    string[] xy = Console.ReadLine().Split();
    int x = int.Parse(xy[0]);
    int y = int.Parse(xy[1]);

    a[y].Add(x);
}

for (int i = 0; i <= n; i++)
{
    a[i].Sort();
}

int result = 0;
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j < a[i].Count; j++)
    {
        if (j == 0)
        {
            result += a[i][j + 1] - a[i][j];
        }

        else if (j == a[i].Count - 1)
        {
            result += a[i][j] - a[i][j - 1];
        }

        else
        {
            int t = a[i][j + 1] - a[i][j];
            int f = a[i][j] - a[i][j - 1];

            result += Math.Min(t, f);
        }
    }
}

Console.WriteLine(result);
