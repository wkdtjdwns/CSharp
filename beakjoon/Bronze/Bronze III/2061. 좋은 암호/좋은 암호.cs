using System.Numerics;

string[] kl = Console.ReadLine().Split(" ");
BigInteger k = BigInteger.Parse(kl[0]);
int l = int.Parse(kl[1]);

bool[] primes = new bool[l + 1];
primes[1] = true;

for (int i = 2; i < l; i++)
{
    if (primes[i]) { continue; }

    if (k % i == 0)
    {
        Console.WriteLine("BAD " + i);
        return;
    }

    for (int j = i + i; j <= l; j += i)
    {
        primes[j] = true;
    }
}

Console.WriteLine("GOOD");
