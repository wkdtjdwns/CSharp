string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

if (m <= 2)
{
    Console.WriteLine("NEWBIE!");
}

else
{
    if (n >= m)
    {
        Console.WriteLine("OLDBIE!");
    }

    else
    {
        Console.WriteLine("TLE!");
    }
}
