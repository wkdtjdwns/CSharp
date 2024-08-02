int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] nc = Console.ReadLine().Split(" ");
    int n = int.Parse(nc[0]);
    int c = int.Parse(nc[1]);

    if (n % c == 0)
    {
        Console.WriteLine(n / c);
    }

    else
    {
        Console.WriteLine(n / c + 1);
    }
}
