string subject = Console.ReadLine().ToLower();
string[] dh = { "social", "history", "language", "literacy" };
string[] pb = { "bigdata", "public", "society" };
foreach (string str in dh)
{
    if (subject.Contains(str))
    {
        Console.WriteLine("digital humanities");
        return;
    }
}

foreach (string str in pb)
{
    if (subject.Contains(str))
    {
        Console.WriteLine("public bigdata");
        return;
    }
}
