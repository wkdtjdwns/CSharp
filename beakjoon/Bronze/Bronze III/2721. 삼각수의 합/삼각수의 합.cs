int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int total = 0;
    for (int j = 1; j <= n; j++)
    {
        total += j * (j + 1) * (j + 2) / 2;
    }

    Console.WriteLine(total);
}
