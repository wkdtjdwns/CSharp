int Factorial(int n)
{
    if (n < 2)
    {
        return 1;
    }

    return n * Factorial(n - 1);
}

string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);

Console.WriteLine(Factorial(n) / (Factorial(k) * Factorial(n - k)));
