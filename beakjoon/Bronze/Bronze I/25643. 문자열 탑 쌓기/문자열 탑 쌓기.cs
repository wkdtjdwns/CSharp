string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
List<string> strs = new List<string>();
for (int i = 0; i < n; i++)
{
    strs.Add(Console.ReadLine());
}

// 문자열 비교
for (int i = 0; i < n - 1; i++)
{
    string a = strs[i];
    string b = strs[i + 1];
    bool check = false;

    for (int j = 1; j <= m; j++)
    {
        if (a.Substring(m - j) == b.Substring(0, j) || a.Substring(0, j) == b.Substring(m - j))
        {
            check = true;
            break;
        }
    }

    if (!check)
    {
        Console.WriteLine(0);
        return;
    }
}

Console.WriteLine(1);
