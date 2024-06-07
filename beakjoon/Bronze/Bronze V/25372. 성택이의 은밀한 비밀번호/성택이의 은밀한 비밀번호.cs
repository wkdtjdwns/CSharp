int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string password = Console.ReadLine();
    if (password.Length < 6 || password.Length > 9)
    {
        Console.WriteLine("no");
    }

    else
    {
        Console.WriteLine("yes");
    }
}
