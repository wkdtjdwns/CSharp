bool IsPrime(int n)
{
    bool isPrime = true;
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0)
        {
            isPrime = false;
            break;
        };
    };

    return isPrime;
}

string str = Console.ReadLine();
int n = 0;
foreach (char c in str)
{
    if (c >= 'a' && c <= 'z')
    {
        n += (int)c - 96;
    }

    else if (c >= 'A' && c <= 'Z')
    {
        n += (int)c - 38;
    }
}

Console.WriteLine(IsPrime(n) ? "It is a prime word." : "It is not a prime word.");
