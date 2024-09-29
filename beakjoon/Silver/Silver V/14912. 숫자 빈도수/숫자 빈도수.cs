string[] nd = Console.ReadLine().Split(" ");
int n = int.Parse(nd[0]);
int d = int.Parse(nd[1]);
int result = 0;
for (int i = 1; i <= n; i++)
{
    int num = i;
    while (num > 0)
    {
        if (num % 10 == d)
        {
            result++;
        }

        num /= 10;
    }
}

Console.WriteLine(result);
