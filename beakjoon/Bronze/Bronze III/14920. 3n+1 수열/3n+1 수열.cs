int n = int.Parse(Console.ReadLine());
int cnt = 0;
while (cnt < int.MaxValue)
{
    cnt++;

    if (n == 1) { break; }
    if (n % 2 == 1)
    {
        n = n * 3 + 1;
    }

    else
    {
        n /= 2;
    }
}

Console.WriteLine(cnt);
