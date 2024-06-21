string[] skh = Console.ReadLine().Split(" ");
int s = int.Parse(skh[0]);
int k = int.Parse(skh[1]);
int h = int.Parse(skh[2]);

if (s + k + h >= 100)
{
    Console.WriteLine("OK");
}

else
{
    if (s < k && s < h)
    {
        Console.WriteLine("Soongsil");
    }

    else if (k < s && k < h)
    {
        Console.WriteLine("Korea");
    }

    else if (h < s && h < k)
    {
        Console.WriteLine("Hanyang");
    }
}
