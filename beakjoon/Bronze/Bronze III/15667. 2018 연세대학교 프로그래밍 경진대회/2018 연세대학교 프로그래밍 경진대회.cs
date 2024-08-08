int k = int.Parse(Console.ReadLine());
for (int i = 1; i <= k; i++)
{
    if (1 + i + i * i == k)
    {
        Console.WriteLine(i);
        break;
    }
}
