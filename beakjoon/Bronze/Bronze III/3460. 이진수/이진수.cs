int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int digit = 0;

    while (n > 0)
    {
        if (n % 2 == 1)
        {
            Console.Write(digit + " ");
        }

        n /= 2;
        digit++;
    }
}
