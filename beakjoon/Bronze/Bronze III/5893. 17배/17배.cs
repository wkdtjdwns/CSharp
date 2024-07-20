using System.Numerics;

string n = Console.ReadLine();
string result = BigIntegerToBinary(ConvertToBigInteger(n) * 17);

Console.WriteLine(result);

BigInteger ConvertToBigInteger(string n)
{
    BigInteger result = 0;
    foreach (char c in n)
    {
        result *= 2;

        if (c == '1') { result += 1; }
    }

    return result;
}

string BigIntegerToBinary(BigInteger value)
{
    if (value == 0) { return "0"; }
    string result = "";

    while (value > 0)
    {
        result = (value % 2 == 0 ? "0" : "1") + result;
        value /= 2;
    }

    return result;
}
