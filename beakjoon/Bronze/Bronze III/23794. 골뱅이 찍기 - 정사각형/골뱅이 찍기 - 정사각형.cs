int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n + 2; i++)
{
    Console.Write("@");
}

Console.WriteLine();

for (int i = 0;i < n; i++)
{
    Console.Write("@");
    for (int j = 0; j < n; j++)
    {
        Console.Write(" ");
    }

    Console.WriteLine("@");
}

for (int i = 0; i < n + 2 ; i++)
{
    Console.Write("@");
}
