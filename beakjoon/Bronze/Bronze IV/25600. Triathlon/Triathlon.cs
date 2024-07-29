int n = int.Parse(Console.ReadLine());
int max = 0;
for (int i = 0; i < n; i++)
{
    string[] adg = Console.ReadLine().Split(" ");
    int a = int.Parse(adg[0]);
    int d = int.Parse(adg[1]);
    int g = int.Parse(adg[2]);

    int score = a * (d + g);
    if (a == d + g) { score *= 2; }

    max = Math.Max(max, score);
}

Console.WriteLine(max);
