string[] nmMtr = Console.ReadLine().Split(" ");
int n = int.Parse(nmMtr[0]);
int m = int.Parse(nmMtr[1]);
int M = int.Parse(nmMtr[2]);
int t = int.Parse(nmMtr[3]);
int r = int.Parse(nmMtr[4]);
int mix = m;
int cnt = 0;

if ((M - m) < t)
{
    Console.WriteLine(-1);
}

else
{
    while (true)
    {
        if ((m + t) <= M)
        {
            m += t;
            n--;
        }

        else
        {
            m -= r;
        }

        if (m < mix)
        {
            m = mix;
        }

        cnt++;
        if (n == 0)
        {
            break;
        }
    }

    Console.WriteLine(cnt);
}
