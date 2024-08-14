int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] xy = Console.ReadLine().Split(" ");
    int x = int.Parse(xy[0]);
    int y = int.Parse(xy[1]);

    int result = -1;
    if (x >= 12 && y >= 4)
    {
        result = 11 * y + 4;
    }

    Console.WriteLine(result);
}
