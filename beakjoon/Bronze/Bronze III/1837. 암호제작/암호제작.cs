using System.Numerics;

string[] pk = Console.ReadLine().Split(" ");

BigInteger p = BigInteger.Parse(pk[0]);
BigInteger k = BigInteger.Parse(pk[1]);
BigInteger i = BigInteger.Parse("1");

while (true)
{
    if (i > k || i == k)
    {
        Console.WriteLine("GOOD");
        break;
    }

    i++;

    if (p % i == 0 && i < k)
    {
        Console.WriteLine("BAD " + i);
        break;
    }
}
