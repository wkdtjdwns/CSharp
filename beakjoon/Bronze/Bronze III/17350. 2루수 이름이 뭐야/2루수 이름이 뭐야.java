int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    if (name.Equals("anj"))
    {
        Console.WriteLine("뭐야;");
        return;
    }
}

Console.WriteLine("뭐야?");
