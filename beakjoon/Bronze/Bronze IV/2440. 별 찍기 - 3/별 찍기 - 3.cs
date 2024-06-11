int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = (n - i); j > 0; j--) {
        Console.Write("*");
    }

    Console.WriteLine();
}
