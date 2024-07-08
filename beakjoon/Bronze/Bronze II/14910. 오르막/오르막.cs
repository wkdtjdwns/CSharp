string[] values = Console.ReadLine().Split(" ");
for (int i = 1; i < values.Length; i++)
{
    if (int.Parse(values[i -1]) > int.Parse(values[i]))
    {
        Console.WriteLine("Bad");
        return;
    }
}

Console.WriteLine("Good");
