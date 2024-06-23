int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] xyz = Console.ReadLine().Split(" ");
    int x = int.Parse(xyz[0]);
    int y = int.Parse(xyz[1]);
    int z = int.Parse(xyz[2]);

    Console.WriteLine(Math.Min(Math.Min(x, y), z));
}
