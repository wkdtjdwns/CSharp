int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] ab = Console.ReadLine().Split(",");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    Console.WriteLine(a + b);
}
