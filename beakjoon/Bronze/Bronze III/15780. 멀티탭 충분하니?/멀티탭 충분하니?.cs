string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);

int[] aValue = new int[k];
string[] a = Console.ReadLine().Split(" ");
for (int i = 0; i < k; i++)
{
    aValue[i] = int.Parse(a[i]);
}

int multiTab = 0;
foreach (int i in aValue)
{
    multiTab += i / 2;
    if (i % 2 == 1)
    {
        multiTab += 1;
    }
}

Console.WriteLine(multiTab >= n ? "YES" : "NO");
