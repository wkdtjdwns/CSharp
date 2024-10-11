int n = int.Parse(Console.ReadLine());
Dictionary<string, int> map = new Dictionary<string, int>();
List<int> list = new List<int>();
for (int i = 0; i < n; i++)
{
    for (int j = 1; j <= 4; j++)
    {
        string[] input = Console.ReadLine().Split(" ");
        for (int k = 0; k < 7; k++)
        {
            string name = input[k];
            if (name.Equals("-"))
            {
                continue;
            }

            if (!map.ContainsKey(name))
            {
                map[name] = 0;
            }

            if (j == 1 || j == 3)
            {
                map[name] += 4;
            }

            else if (j == 2)
            {
                map[name] += 6;
            }

            else
            {
                map[name] += 10;
            }
        }
    }
}

if (map.Count == 0)
{
    Console.WriteLine("Yes");
}

else
{
    list = new List<int>(map.Values);
    list.Sort();

    if (list[list.Count - 1] - list[0] > 12)
    {
        Console.WriteLine("No");
    }

    else
    {
        Console.WriteLine("Yes");
    }
}
