int n = int.Parse(Console.ReadLine());
int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int result = 0;
Array.Sort(arr);
for (int k = 1; k <= n; k++)
{
    if (arr[n - k] >= k)
    {
        result = k;
    }

    else
    {
        break;
    }
}

Console.WriteLine(result);
