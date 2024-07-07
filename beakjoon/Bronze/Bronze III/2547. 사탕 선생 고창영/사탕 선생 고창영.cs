using System.Numerics;

int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    String q = Console.ReadLine();

    int n = int.Parse(Console.ReadLine());
    BigInteger sum = 0;

    for (int j = 0; j < n; j++)
    {
        sum += BigInteger.Parse(Console.ReadLine());
    }

    Console.WriteLine( (sum % n) == 0 ? "YES" : "NO" );
}
