bool IsInterestingNum(int n)
{
    int sum = 0;
    int num = n;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }

    return num % sum == 0;
}

int n = int.Parse(Console.ReadLine());
int cnt = 0;
for (int i = 1; i <= n; i++)
{
    if (IsInterestingNum(i))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
