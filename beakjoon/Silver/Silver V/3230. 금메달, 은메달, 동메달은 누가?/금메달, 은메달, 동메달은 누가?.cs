string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
int[] rank1 = new int[n + 1];
for (int i = 1; i <= n; i++)
{
    int perRank = int.Parse(Console.ReadLine());
    if (rank1[perRank] != 0)
    {
        for (int j = i; j > perRank; j--)
        {
            rank1[j] = rank1[j - 1];
        }
    }

    rank1[perRank] = i;
}

int[] rank2 = new int[m + 1];
int m2 = m;
for (int i = 1; i <= m2; i++, m--)
{
    int perRank = int.Parse(Console.ReadLine());
    if (rank2[perRank] != 0)
    {
        for (int j = i; j > perRank; j--)
        {
            rank2[j] = rank2[j - 1];
        }
    }

    rank2[perRank] = rank1[m];
}

Console.WriteLine(rank2[1]);
Console.WriteLine(rank2[2]);
Console.WriteLine(rank2[3]);
