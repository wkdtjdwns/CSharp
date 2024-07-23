int i = 1;
while (true)
{
    string[] abc = Console.ReadLine().Split(" ");
    double a = double.Parse(abc[0]);
    double b = double.Parse(abc[1]);
    double c = double.Parse(abc[2]);

    if (a == 0 && b == 0 && c == 0) { break; }

    Console.WriteLine("Triangle #" + i);

    if (a == -1)
    {
        if (c <= b)
        {
            Console.WriteLine("Impossible.");
        }

        else
        {
            a = Math.Sqrt((c * c) - (b * b));
            Console.WriteLine("a = " + a.ToString("F3"));
        }
    }

    if (b == -1)
    {
        if (c <= a)
        {
            Console.WriteLine("Impossible.");
        }

        else
        {
            b = Math.Sqrt((c * c) - (a * a));
            Console.WriteLine("b = " + b.ToString("F3"));
        }
    }

    if (c == -1)
    {
        c = Math.Sqrt((a * a) + (b * b));
        Console.WriteLine("c = " + c.ToString("F3"));
    }

    i++;
    Console.WriteLine();
}
