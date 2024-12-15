string GetResult(int m)
{
    if (m <= 26)
    {
        return ((char)('A' + m - 1)).ToString();
    }

    m -= 27;
    char first = (char)('a' + m / 26);
    char second = (char)('a' + m % 26);

    return $"{first}{second}";
}

string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

Console.WriteLine($"SN {n}{GetResult(m)}");
