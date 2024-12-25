int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

foreach(char c in str)
{
    if (Char.IsUpper(c))
    {
        Console.Write(Char.ToLower(c));
    }

    else
    {
        Console.Write(Char.ToUpper(c));
    }
}
