int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] nk = Console.ReadLine().Split(" ");
    int n = int.Parse(nk[0]);
    int k = int.Parse(nk[1]);

    int cnt = 0;
    string[] candies = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        int candy = int.Parse(candies[j]);
        cnt += candy / k;
    }

    Console.WriteLine(cnt);
}
