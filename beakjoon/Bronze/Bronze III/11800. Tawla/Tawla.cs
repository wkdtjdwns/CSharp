Dictionary<int, string> d = new Dictionary<int, string>()
{
    { 1, "Yakk" },
    { 2, "Doh"},
    { 3, "Seh" },
    { 4, "Ghar" },
    { 5, "Bang" },
    { 6, "Sheesh" }
};

int t = int.Parse(Console.ReadLine());
for (int i = 1; i <= t; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    if (a == b)
    {
        switch (a)
        {
            case 1:
                Console.WriteLine($"Case {i}: Habb Yakk");
                break;

            case 2:
                Console.WriteLine($"Case {i}: Dobara");
                break;

            case 3:
                Console.WriteLine($"Case {i}: Dousa");
                break;

            case 4:
                Console.WriteLine($"Case {i}: Dorgy");
                break;

            case 5:
                Console.WriteLine($"Case {i}: Dabash");
                break;

            case 6:
                Console.WriteLine($"Case {i}: Dosh");
                break;
        }
    }

    else
    {
        int h = Math.Max(a, b);
        int l = Math.Min(a, b);

        if ((h == 6 && l == 5) || (h == 5 && l == 6))
        {
            Console.WriteLine($"Case {i}: Sheesh Beesh");
        }

        else
        {
            Console.WriteLine($"Case {i}: {d[h]} {d[l]}");
        }
    }
}
