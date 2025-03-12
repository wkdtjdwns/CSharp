string[] ab = Console.ReadLine().Split(" ");

long result = 0;
foreach (char a in ab[0])
{
    foreach (char b in ab[1])
    {
        result += (a - '0') * (b - '0');
    }
}

Console.WriteLine(result);
