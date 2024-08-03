string n = Console.ReadLine();
int cnt = 0;
while (n.Length > 1)
{
    int result = 1;
    foreach (char c in n)
    {
        result *= (c - '0');
    }

    n = result.ToString();
    cnt++;
}

Console.WriteLine(cnt);
