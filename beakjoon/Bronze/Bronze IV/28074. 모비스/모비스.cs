int[] mobis = new int[5];
string str = Console.ReadLine();

foreach (char c in str)
{
    if (c == 'M') mobis[0] = 1;
    if (c == 'O') mobis[1] = 1;
    if (c == 'B') mobis[2] = 1;
    if (c == 'I') mobis[3] = 1;
    if (c == 'S') mobis[4] = 1;
}

foreach (int result in mobis)
{
    if (result == 0)
    {
        Console.WriteLine("NO");
        return;
    }
}

Console.WriteLine("YES");
