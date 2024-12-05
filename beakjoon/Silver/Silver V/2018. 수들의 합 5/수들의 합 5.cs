int n = int.Parse(Console.ReadLine());
int start = 0;
int end = 0;
int sum = 0;
int cnt = 0;
while (start <= n)
{
    while (++end <= n)
    {
        sum += end;
        if (sum >= n)
        {
            if (sum == n)
            {
                cnt++;
            }

            break;
        }
    }

    while (++start <= n)
    {
        sum -= start;
        if (sum <= n)
        {
            if (sum == n)
            {
                cnt++;
            }

            break;
        }
    }
}

Console.WriteLine(cnt);
