using System.Numerics;

BigInteger Factorial(int n)
{
    if (n < 2)
    {
        return 1;
    }

    BigInteger result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }

    return result;
}

string str;
while ((str = Console.ReadLine()) != null)
{
    int n = int.Parse(str);
    BigInteger factorial = Factorial(n);
    string facString = factorial.ToString();
    char result = '0';

    for (int i = facString.Length - 1; i >= 0; i--)
    {
        if (facString[i] != '0')
        {
            result = facString[i];
            break;
        }
    }

    Console.Write(" ");
    for (int i = 0; i < 4 - str.Length; i++)
    {
        Console.Write(" ");
    }

    Console.WriteLine(n + " -> " + result);
}
