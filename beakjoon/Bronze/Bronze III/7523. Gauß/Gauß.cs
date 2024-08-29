using System.Numerics;

int t = int.Parse(Console.ReadLine());
for (int i = 1; i <= t; i++)
{
    string[] nm = Console.ReadLine().Split(" ");
    int n = int.Parse(nm[0]);
    int m = int.Parse(nm[1]);

    BigInteger cnt = m - n + 1;
    BigInteger sum = cnt * (n + m) / 2;

    Console.WriteLine($"Scenario #{i}:");
    Console.WriteLine(sum);
    Console.WriteLine();
}
