int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n + 1; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        sum += i + j;
    }
}

Console.WriteLine(sum);
