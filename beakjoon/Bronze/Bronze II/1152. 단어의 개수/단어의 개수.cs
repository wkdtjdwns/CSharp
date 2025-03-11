string str = Console.ReadLine().Trim();
if (str.Length == 0)
{
    Console.WriteLine(0);
    return;
}

int cnt = 1;
foreach (char c in str)
{
    if (c == ' ')
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
