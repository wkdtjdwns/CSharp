using System.Numerics;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    BigInteger k = BigInteger.Parse(Console.ReadLine());
    if (k % 2 == 0) { Console.WriteLine("even"); }
    else { Console.WriteLine("odd"); }
}
