string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

HashSet<string> s = new HashSet<string>();
for (int i = 0; i < n; i++)
{
    s.Add(Console.ReadLine());
}

int cnt = 0;
for (int i = 0; i < m; i++)
{
    string checkStr = Console.ReadLine();
    if (s.Contains(checkStr)) { cnt++; }
}

Console.WriteLine(cnt);
