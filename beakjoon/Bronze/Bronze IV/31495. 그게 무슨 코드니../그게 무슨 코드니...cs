string str = Console.ReadLine();
if (str.Length > 2 && str.StartsWith("\"") && str.EndsWith("\""))
{
    Console.WriteLine(str.Substring(1, str.Length - 2));
}

else
{
    Console.WriteLine("CE");
}
