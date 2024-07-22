int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    Console.WriteLine($"Case {i}: {a + b}");
}
