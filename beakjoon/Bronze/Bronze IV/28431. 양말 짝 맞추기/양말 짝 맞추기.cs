List<int> x = new List<int>();
for (int i = 0; i < 5; i++)
{
    x.Add(int.Parse(Console.ReadLine()));
}

Dictionary<int, int> d = new Dictionary<int, int>();

foreach (int sock in x)
{
    if (d.ContainsKey(sock))
    {
        d[sock]++;
    }

    else
    {
        d[sock] = 1;
    }
}

foreach (var pair in d)
{
    if (pair.Value % 2 != 0)
    {
        Console.WriteLine(pair.Key);
        break;
    }
}
