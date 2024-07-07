int maxValue = 0;
int maxIndex = 0;

for (int i = 1; i <= 9; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n > maxValue)
    {
        maxValue = n;
        maxIndex = i;
    }
}

Console.WriteLine(maxValue);
Console.WriteLine(maxIndex);
