string[] kn = Console.ReadLine().Split(" ");
long k = long.Parse(kn[0]);
long n = long.Parse(kn[1]);

if (n == 1)
{
    Console.WriteLine(-1);
}

else
{
    Console.WriteLine((k * n + (n - 2)) / (n - 1));
}
