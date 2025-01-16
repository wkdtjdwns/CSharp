while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == -1)
    {
        break;
    }

    List<int> divisors = new List<int>();
    int sum = 0;

    for (int i = 1; i <= n / 2; i++)
    {
        if (n % i == 0)
        {
            divisors.Add(i);
            sum += i;
        }
    }

    if (sum == n)
    {
        Console.WriteLine($"{n} = {string.Join(" + ", divisors)}");
    }

    else
    {
        Console.WriteLine($"{n} is NOT perfect.");
    }
}
