int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    string s = "Pairs for " + n + ": ";
    for (int j = 1; j <= n / 2; j++)
    {
        if (j != (n - j))
        {
            if (j > 1)
            {
                s += ", ";
            }

            s += j + " " + (n - j);
        }
    }

    Console.WriteLine(s);
}
