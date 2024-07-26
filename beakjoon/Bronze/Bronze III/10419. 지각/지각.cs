int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int d = int.Parse(Console.ReadLine());
    int max = 1;
    while (max + (max * max) <= d)
    {
        max++;
    }

    Console.WriteLine(max - 1);
}
