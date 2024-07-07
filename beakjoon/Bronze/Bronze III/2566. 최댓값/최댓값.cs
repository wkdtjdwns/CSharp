int maxValue = 0;
int maxRow = 1;
int maxCol = 1;

for (int i = 1; i <= 9; i++)
{
    string[] values = Console.ReadLine().Split(" ");

    for (int j = 1; j <= 9; j++)
    {
        int n = int.Parse(values[j - 1]);

        if (n > maxValue)
        {
            maxValue = n;
            maxRow = i;
            maxCol = j;
        }
    }
}

Console.WriteLine(maxValue);
Console.WriteLine(maxRow + " " + maxCol);
