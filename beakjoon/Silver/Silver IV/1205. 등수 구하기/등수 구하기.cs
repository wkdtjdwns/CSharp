string[] nnp = Console.ReadLine().Split(" ");
int n = int.Parse(nnp[0]);
int newScore = int.Parse(nnp[1]);
int p = int.Parse(nnp[2]);

if (n == 0)
{
    Console.WriteLine(1);
    return;
}

string[] input = Console.ReadLine().Split(" ");
int[] scores = new int[n];
for (int i = 0; i < n; i++)
{
    scores[i] = int.Parse(input[i]);
}

if (n == p && newScore <= scores[n - 1])
{
    Console.WriteLine(-1);
    return;
}

int rank = 1;
for (int i = 0; i < n; i++)
{
    if (newScore < scores[i])
    {
        rank++;
    }

    else
    {
        break;
    }
}

if (n < p || newScore > scores[n - 1])
{
    Console.WriteLine(rank);
}

else
{
    Console.WriteLine(-1);
}
