int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int k = 0; k < i; k++)
    {
        Console.Write("*");
    }
    
    Console.WriteLine();
}

for (int i = 1; i < n; i++)
{
    for (int k = 0; k < n - i; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}
