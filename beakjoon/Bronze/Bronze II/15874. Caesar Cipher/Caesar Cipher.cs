string[] ks = Console.ReadLine().Split(" ");
int k = int.Parse(ks[0]) % 26;
int s = int.Parse(ks[1]);

string str = Console.ReadLine();

foreach (char c in str)
{
    if (c == ' ' || c == '.' || c == ',')
    {
        Console.Write(c);
    }

    else if (c >= 65 && c <= 90 && c + k > 90)
    {
        Console.Write((char)(64 + (c + k - 90)));
    }

    else if (c >= 97 && c <= 122 && c + k > 122)
    {
        Console.Write((char)(96 + c + k - 122));
    }

    else
    {
        Console.Write((char)((int)c + k));
    }
}
