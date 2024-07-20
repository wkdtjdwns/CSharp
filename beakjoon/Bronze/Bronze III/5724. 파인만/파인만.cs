while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0) { break; }

    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += (n - i + 1) * (n - i + 1);
    }

    Console.WriteLine(result);
}
