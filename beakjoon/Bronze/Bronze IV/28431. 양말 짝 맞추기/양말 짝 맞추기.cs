Dictionary<int, int> d = new Dictionary<int, int>();
for (int i = 0; i < 5; i++)
{
    int x = int.Parse(Console.ReadLine());
    if (d.ContainsKey(x))
    {
        d[x]++;
    }

    else { d[x] = 1; }
}

foreach (int key in d.Keys)
{
    if (key % 2 == 1)
    {
        Console.WriteLine(key);
        break;
    }
}
