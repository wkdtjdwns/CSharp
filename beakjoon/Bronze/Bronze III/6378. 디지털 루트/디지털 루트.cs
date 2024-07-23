while (true)
{
    string n = Console.ReadLine();
    if (n.Equals("0")) { break; }

    while (n.Length > 1)
    {
        int sum = 0;
        foreach (char c in n)
        {
            sum += c - '0';
        }

        n = sum.ToString();
    }

    Console.WriteLine(n);
}
