int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] rec = Console.ReadLine().Split(" ");
    int r = int.Parse(rec[0]);
    int e = int.Parse(rec[1]);
    int c = int.Parse(rec[2]);
    int diff = e - c;
    if (r > diff)
    {
        Console.WriteLine("do not advertise");
    }

    else if (r < diff)
    {
        Console.WriteLine("advertise");
    }

    else
    {
        Console.WriteLine("does not matter");
    }
}
