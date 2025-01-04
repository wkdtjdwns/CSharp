string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
int[,] a = new int[n, m];
for (int i = 0; i < n; i++)
{
    string[] aValue = Console.ReadLine().Split(" ");
    for (int j = 0; j < m; j++)
    {
        a[i, j] = int.Parse(aValue[j]);
    }
}

string[] mk = Console.ReadLine().Split(" ");
int k = int.Parse(mk[1]);
int[,] b = new int[m, k];
for (int i = 0; i < m; i++)
{
    string[] bValue = Console.ReadLine().Split(" ");
    for (int j = 0; j < k; j++)
    {
        b[i, j] = int.Parse(bValue[j]);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < k; j++)
    {
        int result = 0;
        for (int l = 0; l < m; l++)
        {
            result += a[i, l] * b[l, j];
        }

        Console.Write(result + " ");
    }

    Console.WriteLine();
}
