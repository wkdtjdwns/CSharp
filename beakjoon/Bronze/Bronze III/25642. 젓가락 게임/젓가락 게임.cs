string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);
while (true)
{
    b += a;
    if (b >= 5)
    {
        Console.WriteLine("yt");
        break;
    }

    a += b;
    if (a >= 5)
    {
        Console.WriteLine("yj");
        break;
    }
}
