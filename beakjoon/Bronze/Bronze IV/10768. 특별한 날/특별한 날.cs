int month = int.Parse(Console.ReadLine());
int day = int.Parse(Console.ReadLine());

if (month == 2)
{
    if (day > 18)
    {
        Console.WriteLine("After");
    }

    else if (day < 18)
    {
        Console.WriteLine("Before");
    }

    else
    {
        Console.WriteLine("Special");
    }
}

else if (month > 2)
{
    Console.WriteLine("After");
}

else
{
    Console.WriteLine("Before");
}
