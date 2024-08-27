int[] temp = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] ym = Console.ReadLine().Split(" ");
    int y = int.Parse(ym[0]);
    int m = int.Parse(ym[1]);
    if (m == 1)
    {
        Console.WriteLine(y - 1 + " " + 12 + " " + 31);
    }

    else
    {
        Console.Write(y + " " + (m - 1) + " ");
        if (m == 3 && ((y % 100 != 0 && y % 4 == 0) || y % 400 == 0))
        {
            Console.WriteLine(29);
        }

        else
        {
            Console.WriteLine(temp[m - 1]);
        }
    }
}
