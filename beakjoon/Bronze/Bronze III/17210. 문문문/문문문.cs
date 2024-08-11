long n = long.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());

if (n > 5)
{
    Console.WriteLine("Love is open door");
}

else
{
    for (int i = 0; i < n - 1; i++)
    {
        if (num == 1)
        {
            Console.WriteLine(0);
            num = 0;
        }

        else
        {
            Console.WriteLine(1);
            num = 1;
        }
    }
}
