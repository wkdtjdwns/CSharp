int n = int.Parse(Console.ReadLine());
string[] results = Console.ReadLine().Split(" ");

int total = 0;
int bonus = 0;
foreach (string value in results)
{
    int score = int.Parse(value);
    if (score == 0)
    {
        bonus = 0;
        continue;
    }

    total += 1 + bonus;
    bonus++;
}

Console.WriteLine(total);
