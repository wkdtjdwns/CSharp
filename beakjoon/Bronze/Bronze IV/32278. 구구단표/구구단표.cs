int n = int.Parse(Console.ReadLine());
for (int i = 2; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        if (n == i || n == j || n == (i * j))
        {
            Console.WriteLine(1);
            return;
        }
    }
}

Console.WriteLine(0);
