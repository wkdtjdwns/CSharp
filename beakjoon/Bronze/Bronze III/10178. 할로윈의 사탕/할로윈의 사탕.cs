int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] cv = Console.ReadLine().Split(" ");
    int c = int.Parse(cv[0]);
    int v = int.Parse(cv[1]);

    Console.WriteLine("You get " + c / v + " piece(s) and your dad gets " + c % v + " piece(s).");
}
