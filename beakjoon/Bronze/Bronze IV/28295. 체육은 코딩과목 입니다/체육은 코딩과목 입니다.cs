int total = 0;
for (int i = 0; i < 10; i++)
{
    int command = int.Parse(Console.ReadLine());
    total = (total + command) % 4;
}

if (total == 0)
{
    Console.WriteLine("N");
}

else if (total == 1)
{
    Console.WriteLine("E");
}

else if (total == 2)
{
    Console.WriteLine("S");
}

else
{
    Console.WriteLine("W");
}
