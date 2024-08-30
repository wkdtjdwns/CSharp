int n = int.Parse(Console.ReadLine());
int[] t = new int[n];
int[] s = new int[n];

for (int i = 0; i < n; i++)
{
    string[] ts = Console.ReadLine().Split(" ");
    t[i] = int.Parse(ts[0]);
    s[i] = int.Parse(ts[1]);
}

int max = int.MinValue;
int f = -1;
for (int i = 0; i < n; i++)
{
    if (s[i] > max)
    {
        max = s[i];
        f = i;
    }
}

int result = 0;
if (max == 1 || max == 4)
{
    result = t[f] + f * 20;
}

Console.WriteLine(result);
