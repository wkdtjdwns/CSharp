int n = int.Parse(Console.ReadLine());
int[][] classes = new int[n][];

for (int i = 0; i < n; i++)
{
    classes[i] = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
}

int max = 0;
int leader = 0;
for (int i = 0; i < n; i++)
{
    HashSet<int> set = new HashSet<int>();
    for (int j = 0; j < 5; j++)
    {
        for (int k = 0; k < n; k++)
        {
            if (classes[i][j] == classes[k][j] && i != k)
            {
                set.Add(k);
            }
        }
    }

    if (set.Count > max)
    {
        leader = i;
        max = set.Count;
    }
}

Console.WriteLine(leader + 1);
