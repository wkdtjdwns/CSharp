int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int cnt = 0;
    for (int j = 2; j <= n; j++)
    {
        int value = n;
        while (true)
        {
            if (value % j != 0)
            {
                break;
            }

            cnt++;
            value /= j;
        }
    }

    Console.WriteLine(cnt);
}
