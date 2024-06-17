string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);

for (int i = 0; i < n; i++)
{
    string shape = Console.ReadLine();
    for (int j = shape.Length - 1; j >= 0; j--)
    {
        Console.Write(shape[j]);
    }

    Console.WriteLine();
}
