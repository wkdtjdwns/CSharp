string h = Console.ReadLine();
string n = Console.ReadLine();
int cnt = 0;
for (int i = 0; i < h.Length; i++)
{
    bool check = false;
    for (int j = 0; j < n.Length; j++)
    {
        if (i + j >= h.Length || h[i + j] != n[j])
        {
            check = true;
            break;
        }
    }

    if (!check)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
