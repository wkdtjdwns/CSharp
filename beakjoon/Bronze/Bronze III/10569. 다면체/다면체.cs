int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] ve = Console.ReadLine().Split(" ");
    int v = int.Parse(ve[0]);
    int e = int.Parse(ve[1]);

    Console.WriteLine(e - v + 2);
}
