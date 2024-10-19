string[] nx = Console.ReadLine().Split(" ");
int n = int.Parse(nx[0]);
int x = int.Parse(nx[1]);
long sum = 0;

for (int i = 0; i <= n; i++)
{
    string[] a = Console.ReadLine().Split(" ");
    int ai = int.Parse(a[0]);
    if (i == 0)
    {
        sum = ai;
    }

    else
    {
        sum = (ai + sum * x) % 1000000007;
    }
}

Console.WriteLine(sum);
