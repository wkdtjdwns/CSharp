string[] abc = Console.ReadLine().Split(" ");
int a = int.Parse(abc[0]);
int b = int.Parse(abc[1]);
int c = int.Parse(abc[2]);
int group = int.Parse(Console.ReadLine());
int max = 0;
for (int i = 0; i < group; i++)
{
    int score = 0;
    for (int j = 0; j < 3; j++)
    {
        string[] cnt = Console.ReadLine().Split(" ");
        score += a * int.Parse(cnt[0]);
        score += b * int.Parse(cnt[1]);
        score += c * int.Parse(cnt[2]);
    }

    max = Math.Max(max, score);
}

Console.WriteLine(max);
