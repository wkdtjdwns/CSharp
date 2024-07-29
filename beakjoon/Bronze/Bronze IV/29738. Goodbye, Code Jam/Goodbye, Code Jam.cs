int t = int.Parse(Console.ReadLine());
for (int i = 1; i <= t; i++)
{
    int n = int.Parse(Console.ReadLine());
    Console.Write("Case #" + i + ": ");

    if (n > 4500) { Console.WriteLine("Round 1"); }
    else if (n > 1000) { Console.WriteLine("Round 2"); }
    else if (n > 25) { Console.WriteLine("Round 3"); }
    else { Console.WriteLine("World Finals"); }
}
