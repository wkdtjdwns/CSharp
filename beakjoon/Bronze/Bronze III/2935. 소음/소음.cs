using System.Numerics;

BigInteger a = BigInteger.Parse(Console.ReadLine());
string op = Console.ReadLine();
BigInteger b = BigInteger.Parse(Console.ReadLine());

if (op.Equals("+"))
{
    Console.WriteLine(a + b);
}

else
{
    Console.WriteLine(a * b);
}
