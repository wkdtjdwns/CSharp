int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int year = n % 100;

    if ((n + 1) % year == 0)
    {
        Console.WriteLine("Good");
    }

    else
    {
        Console.WriteLine("Bye");
    }
}
