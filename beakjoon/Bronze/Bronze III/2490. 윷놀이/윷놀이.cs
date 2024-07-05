for (int i = 0; i < 3; i++)
{
    string[] abcd = Console.ReadLine().Split(" ");
    int a = int.Parse(abcd[0]);
    int b = int.Parse(abcd[1]);
    int c = int.Parse(abcd[2]);
    int d = int.Parse(abcd[3]);

    int result = a + b + c + d;
    if (result == 3)
    {
        Console.WriteLine("A");
    }

    else if (result == 2)
    {
        Console.WriteLine("B");
    }

    else if (result == 1)
    {
        Console.WriteLine("C");
    }

    else if (result == 0)
    {
        Console.WriteLine("D");
    }

    else
    {
        Console.WriteLine("E");
    }
}
