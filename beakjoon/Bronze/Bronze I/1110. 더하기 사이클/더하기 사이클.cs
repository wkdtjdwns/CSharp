int n = int.Parse(Console.ReadLine());
int temp = n;
int cnt = 0;
while (true)
{
    n = ((n % 10) * 10) + (((n / 10) + (n % 10)) % 10);
    cnt++;

    if (temp == n)
    {
        break;
    }
}

Console.WriteLine(cnt);
