long factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }

    return n * factorial(n - 1);
}

int n = int.Parse(Console.ReadLine());
Console.WriteLine(factorial(n));
