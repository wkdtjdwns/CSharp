string[] nm = Console.ReadLine().Split();
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
char[,] schedule = new char[n, m];

for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < m; j++)
    {
        schedule[i, j] = line[j];
    }
}

for (int i = 0; i < m; i++)
{
    bool canEscape = true;
    for (int j = 0; j < n; j++)
    {
        if (schedule[j, i] == 'O')
        {
            canEscape = false;
            break;
        }
    }

    if (canEscape)
    {
        Console.WriteLine(i + 1);
        return;
    }
}

Console.WriteLine("ESCAPE FAILED");
