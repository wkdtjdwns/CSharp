string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
int total = 0;
int cnt = 0;

string[] a = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    total += int.Parse(a[i]);
    if (total < 0)
    {
        total = 0;
    }

    if (total >= m)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
