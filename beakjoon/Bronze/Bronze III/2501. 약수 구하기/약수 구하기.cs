string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);

int cnt = 0;
int[] a = new int[n];

int j = 0;
for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        a[j] = i;
        j++;
        cnt++;
    }
}

if (cnt >= k)
{
    Console.WriteLine(a[k - 1]);
}

else
{
    Console.WriteLine(0);
}
