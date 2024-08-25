int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] xy = Console.ReadLine().Split(" ");
    int x = int.Parse(xy[0]);
    int y = int.Parse(xy[1]);
    if (x >= 0 && x <= 23 && y >= 0 && y <= 59)
    {
        Console.Write("Yes ");
    }

    else
    {
        Console.Write("No ");
    }

    if (x >= 1 && x <= 12)
    {
        if ((x == 2 && y >= 1 && y <= 29) ||
              ((x == 4 || x == 6 || x == 9 || x == 11) && y >= 1 && y <= 30) ||
              ((x == 1 || x == 3 || x == 5 || x == 7 || x == 8 || x == 10 || x == 12) && y >= 1 && y <= 31)) {
            Console.WriteLine("Yes");
        }

        else
        {
            Console.WriteLine("No");
        }
    }

    else
    {
        Console.WriteLine("No");
    }
}
