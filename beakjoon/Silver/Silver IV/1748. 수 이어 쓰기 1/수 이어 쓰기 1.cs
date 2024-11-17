int n = int.Parse(Console.ReadLine());
int result = 0;
int plus = 1;
int num = 10;

for (int i = 1; i <= n; i++)
{
    if (i % num == 0)
    {
        plus++;
        num *= 10;
    }

    result += plus;
}

Console.WriteLine(result);
