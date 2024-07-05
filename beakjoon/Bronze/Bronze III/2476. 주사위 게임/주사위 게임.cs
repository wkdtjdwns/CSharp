int n = int.Parse(Console.ReadLine());
int[] results = new int[n];

for (int i = 0; i < n; i++)
{
    string[] abc = Console.ReadLine().Split(" ");
    int a = int.Parse(abc[0]);
    int b = int.Parse(abc[1]);
    int c = int.Parse(abc[2]);

    if (a == b && b == c)
    {
        results[i] = 10000 + (a * 1000);
    }

    else if (a == b || a == c)
    {
        results[i] = 1000 + (a * 100);
    }

    else if (b == c)
    {
        results[i] = 1000 + (b * 100);
    }

    else
    {
        results[i] = Math.Max(Math.Max(a, b), c) * 100;
    }
}

int maxResult = 0;
foreach (int result in results)
{
    if (result > maxResult)
    {
        maxResult = result;
    }
}

Console.WriteLine(maxResult);
