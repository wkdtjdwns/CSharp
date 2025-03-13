int n = int.Parse(Console.ReadLine());
int cnt = 0;
int temp = 0;
while (true)
{
    if (n % 5 == 0)
    {
        cnt += n / 5;
        Console.WriteLine(cnt);
        break;
    }

    else
    {
        n -= 2;
        cnt++;
    }

    if (n < 0)
    {
        Console.WriteLine(-1);
        break;
    }
}
