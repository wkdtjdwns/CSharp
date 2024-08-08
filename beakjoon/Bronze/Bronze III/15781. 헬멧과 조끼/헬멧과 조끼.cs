string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

int cnt1 = 0;
int cnt2 = 0;

string[] h = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    cnt1 = Math.Max(cnt1, int.Parse(h[i]));
}

string[] a = Console.ReadLine().Split(" ");
for (int i = 0; i < m; i++)
{
    cnt2 = Math.Max(cnt2, int.Parse(a[i]));
}

Console.WriteLine(cnt1 + cnt2);
