string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

int[,] a = new int[n, m];
for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(" ");

    for (int j = 0; j < m; j++)
    {
        a[i, j] = int.Parse(values[j]);
    }
}

int[,] b = new int[n, m];
for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(" ");

    for (int j = 0; j < m; j++)
    {
        b[i, j] = int.Parse(values[j]);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a[i, j] + b[i, j] + " ");
    }

    Console.WriteLine();
}
