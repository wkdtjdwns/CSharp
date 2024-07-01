int n = int.Parse(Console.ReadLine());
int[] prices = new int[n];
for (int i = 0; i < n; i++)
{
    prices[i] = int.Parse(Console.ReadLine());
}

int total = 0;
int m = int.Parse(Console.ReadLine());
for (int j = 0; j < m; j++)
{
    int b = int.Parse(Console.ReadLine());
    total += prices[b - 1];
}

Console.WriteLine(total);
