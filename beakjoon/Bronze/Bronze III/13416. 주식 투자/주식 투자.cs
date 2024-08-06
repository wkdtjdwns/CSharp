int t = int.Parse(Console.ReadLine());
int[] stock = new int[3];
for (int j = 0; j < t; j++)
{
    int maxValue = 0;
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string[] stocks = Console.ReadLine().Split(" ");
        stock[0] = int.Parse(stocks[0]);
        stock[1] = int.Parse(stocks[1]);
        stock[2] = int.Parse(stocks[2]);

        if (stock[0] < 0 && stock[1] < 0 & stock[2] < 0)
        {
            continue;
        }

        maxValue += Math.Max(Math.Max(stock[0], stock[1]), stock[2]);
    }

    Console.WriteLine(maxValue);
}
