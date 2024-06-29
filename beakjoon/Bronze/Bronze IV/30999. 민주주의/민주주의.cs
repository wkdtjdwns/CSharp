string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);

int cnt = 0;
for (int i = 0; i < n; i++)
{
    string ox = Console.ReadLine();
    int o = 0;
    int x = 0;
    foreach (char c in ox)
    {
        if (c == 'O') o++;
        else x++;
    }

    if (o > x) cnt++;
}

Console.WriteLine(cnt);
