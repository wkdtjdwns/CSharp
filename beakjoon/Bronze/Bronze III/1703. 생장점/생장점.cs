while (true)
{
    string[] nm = Console.ReadLine().Split(" ");
    int n = int.Parse(nm[0]);
    int tree = 1;

    if (n == 0) { break; }

    for (int i = 0; i < 2 * n; i++)
    {
        int m = int.Parse(nm[i + 1]);
        if (i % 2 == 0) { tree *= m; }
        else { tree -= m; }
    }

    Console.WriteLine(tree);
}
