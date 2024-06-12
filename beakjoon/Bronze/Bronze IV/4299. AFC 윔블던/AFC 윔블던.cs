string[] input = Console.ReadLine().Split(" ");
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

if (a < b)
{
    Console.WriteLine(-1);
}

else
{
    int x = (a + b) / 2;
    int y = (a - b) / 2;

    if (((x + y) == a) && ((x - y) == b))
    {
        Console.WriteLine(x + " " + y);
    }

    else
    {
        Console.WriteLine(-1);
    }
}
