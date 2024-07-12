int max = 0;
int index = 0;
for (int i = 1; i <= 5; i++)
{
    string[] scores = Console.ReadLine().Split(" ");
    int total = 0;
    foreach (string score in scores)
    {
        total += int.Parse(score);
    }

    if (total > max)
    {
        max = total;
        index = i;
    }
}

Console.WriteLine(index + " " +  max);
