string[] adk = Console.ReadLine().Split(" ");
int a = int.Parse(adk[0]);
int d = int.Parse(adk[1]);
int k = int.Parse(adk[2]);

if ((k - a) % d == 0)
{
    int n = (k - a) / d + 1;
    if (n > 0)
    {
        Console.WriteLine(n);
    }

    else
    {
        Console.WriteLine("X");
    }
}

else
{
    Console.WriteLine("X");
}
