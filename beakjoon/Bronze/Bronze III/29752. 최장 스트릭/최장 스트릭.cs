int n = int.Parse(Console.ReadLine());
string[] a = Console.ReadLine().Split(" ");
int cur = 0;
int result = 0;
for (int i = 0; i < n; i++)
{
    if (int.Parse(a[i]) > 0)
    {
        cur++;
        if (cur > result)
        {
            result = cur;
        }
    }

    else
    {
        cur = 0;
    }
}

Console.WriteLine(result);
