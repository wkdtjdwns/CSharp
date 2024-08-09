using System.Numerics;

string[] ab = Console.ReadLine().Split(" ");
BigInteger a = BigInteger.Parse(ab[0]);
BigInteger b = BigInteger.Parse(ab[1]);
BigInteger mod = a % b;
if (mod < 0)
{
    mod += BigInteger.Abs(b);
}

Console.WriteLine((a - mod) / b);
Console.WriteLine(mod);
