int n = int.Parse(Console.ReadLine());

int result = int.MaxValue;
for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    if (b - a < 0)
    {
        continue;
    }

    result = Math.Min(result, b);
}

Console.WriteLine(result == int.MaxValue ? -1 : result);
