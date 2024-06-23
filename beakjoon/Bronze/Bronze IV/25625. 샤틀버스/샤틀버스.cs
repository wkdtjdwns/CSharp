string[] xy = Console.ReadLine().Split(" ");
int x = int.Parse(xy[0]);
int y = int.Parse(xy[1]);

if (x > y)
{
    Console.WriteLine(x + y);
}

else
{
    Console.WriteLine(y - x);
}
