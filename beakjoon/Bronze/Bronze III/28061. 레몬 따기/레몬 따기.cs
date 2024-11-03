int n = int.Parse(Console.ReadLine());
int max = 0;
string[] a = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    int now = int.Parse(a[i]) - n + i;
    if (max < now)
    {
        max = now;
    }
}

Console.WriteLine(max);
