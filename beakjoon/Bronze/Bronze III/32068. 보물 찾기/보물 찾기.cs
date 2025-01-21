int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] lrs = Console.ReadLine().Split(" ");
    int l = int.Parse(lrs[0]);
    int r = int.Parse(lrs[1]);
    int s = int.Parse(lrs[2]);

    int ls = s - l;
    int rs = r - s;
    if (ls < rs)
    {
        Console.WriteLine(ls * 2 + 1);
    }

    else
    {
        Console.WriteLine(rs * 2);
    }
}
