int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    if (name.Contains("S"))
    {
        Console.WriteLine(name);
        break;
    }
}
