string[] nmk = Console.ReadLine().Split(" ");
int n = int.Parse(nmk[0]);
int m = int.Parse(nmk[1]);
int k = int.Parse(nmk[2]);

int[,] array = new int[n, m];
for (int i = 0; i < n; i++)
{
    string[] a = Console.ReadLine().Split(" ");
    for (int j = 0; j < m; j++)
    {
        array[i, j] = int.Parse(a[j]);
    }
}

int[] people = new int[n + 1];
for (int j = 0; j < m; j++)
{
    for (int i = 0; i < n; i++)
    {
        people[i + 1] += array[i, j];
        if (people[i + 1] >= k)
        {
            Console.WriteLine($"{i + 1} {j + 1}");
            return;
        }
    }
}
