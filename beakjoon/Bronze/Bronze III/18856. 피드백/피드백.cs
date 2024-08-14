List<int> GetPrime(int maxNum)
{
    bool[] isPrime = Enumerable.Repeat(true, maxNum + 1).ToArray();
    isPrime[0] = isPrime[1] = false;

    for (int i = 2; i * i <= maxNum; i++)
    {
        if (isPrime[i])
        {
            for (int j = i * i; j <= maxNum; j += i)
                isPrime[j] = false;
        }
    }

    List<int> primes = new List<int>();
    for (int i = 2; i <= maxNum; i++)
    {
        if (isPrime[i]) primes.Add(i);
    }

    return primes;
}

int n = int.Parse(Console.ReadLine()!);
List<int> primes = GetPrime(1000);

Console.WriteLine(n);
Console.Write("1 2 ");
int e = 2;
for (int i = 3; i < n; i++)
{
    e++;
    Console.Write(e + " ");
}

foreach (int prime in primes)
{
    if (prime > e)
    {
        Console.WriteLine(prime);
        break;
    }
}
