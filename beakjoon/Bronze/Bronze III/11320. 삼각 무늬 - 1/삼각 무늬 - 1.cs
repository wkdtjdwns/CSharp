int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    long a = long.Parse(ab[0]);
    long b = long.Parse(ab[1]);

    Console.WriteLine((a / b) * (a / b));
}
