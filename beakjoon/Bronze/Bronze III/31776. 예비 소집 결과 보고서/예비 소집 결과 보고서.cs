int n = int.Parse(Console.ReadLine());
int cnt = 0;
while (n-- > 0)
{
    string[] ts = Console.ReadLine().Split(" ");
    int t1 = int.Parse(ts[0]);
    int t2 = int.Parse(ts[1]);
    int t3 = int.Parse(ts[2]);

    if (t1 != -1)
    {
        if (t2 == -1 && t3 == -1)
        {
            cnt++;
        }

        else if (t2 != -1)
        {
            if ((t1 <= t2) && (t3 == -1 || t2 <= t3))
            {
                cnt++;
            }
        }
    }
}

Console.WriteLine(cnt);
