int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int sum = int.Parse(Console.ReadLine());
    int n = int.Parse(Console.ReadLine());
    for (int j = 0; j < n; j++)
    {
        string[] qp = Console.ReadLine().Split(" ");
        int q = int.Parse(qp[0]);
        int p = int.Parse(qp[1]);

        sum += (q * p);
    }

    Console.WriteLine(sum);
}
