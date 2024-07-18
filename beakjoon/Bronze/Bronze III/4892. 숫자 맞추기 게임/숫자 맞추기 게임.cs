int cnt = 1;

while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0) break;

    if (n % 2 == 0)
    {
        n = (((n * 3) / 2) * 3) / 9;
        Console.WriteLine(cnt + ". even " + n);
    }

    else
    {
        n = ((((n * 3) + 1) / 2) * 3) / 9;
        Console.WriteLine(cnt + ". odd " + n);
    }

    cnt++;
}
