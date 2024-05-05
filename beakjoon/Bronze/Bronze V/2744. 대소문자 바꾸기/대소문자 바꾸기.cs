string str = Console.ReadLine();

/*for (int i = 0; i < str.Length; i++)
{
    if (Char.IsLower(str[i])) Console.Write(Char.ToUpper(str[i]));
    else Console.Write(Char.ToLower(str[i]));
}*/

foreach (char c in str)
{
    if (Char.IsLower(c)) Console.Write(Char.ToUpper(c));
    else Console.Write(Char.ToLower(c));
}
