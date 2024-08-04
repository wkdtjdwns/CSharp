string[] nx = Console.ReadLine().Split(" ");
int n = int.Parse(nx[0]);
int x = int.Parse(nx[1]);

int result = -1;
for (int i = 0; i < n; i++)
{
    string[] st = Console.ReadLine().Split(" ");
    int s = int.Parse(st[0]);
    int t = int.Parse(st[1]);

    if (s + t <= x)
    {
        result = Math.Max(result, s);
    }
}

Console.WriteLine(result);
