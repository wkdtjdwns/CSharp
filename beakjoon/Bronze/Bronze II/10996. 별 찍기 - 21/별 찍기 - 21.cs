int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n * 2; i++)
{
    bool isBlack = false;
    if (i % 2 == 1)
    {
        isBlack = true;
    }

    for (int j = 0; j < n; j++)
    {
        if (isBlack)
        {
            Console.Write(" ");
            isBlack = !isBlack;
        }

        else
        {
            Console.Write("*");
            isBlack = !isBlack;
        }
    }

    Console.WriteLine();
}
