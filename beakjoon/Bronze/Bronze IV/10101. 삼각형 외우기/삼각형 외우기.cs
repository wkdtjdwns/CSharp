int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a + b + c == 180)
{
    if (a == b && b == c)
    {
        Console.WriteLine("Equilateral");
    }

    else if (a == b || a == c || b == c)
    {
        Console.WriteLine("Isosceles");
    }

    else
    {
        Console.WriteLine("Scalene");
    }
}

else
{
    Console.WriteLine("Error");
}
