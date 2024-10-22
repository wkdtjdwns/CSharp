using System.Text;

bool BinarySearch(int[] arr, int target)
{
    int start = 0;
    int end = arr.Length - 1;

    while (start <= end)
    {
        int mid = (start + end) / 2;

        if (arr[mid] == target)
        {
            return true;
        }

        if (arr[mid] < target)
        {
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        }
    }

    return false;
}

StringBuilder sb = new StringBuilder();
int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];

    string[] nj = Console.ReadLine().Split();
    for (int j = 0; j < n; j++)
    {
        arr[j] = int.Parse(nj[j]);
    }

    Array.Sort(arr);

    int m = int.Parse(Console.ReadLine());
    string[] mj = Console.ReadLine().Split();
    for (int j = 0; j < m; j++)
    {
        int target = int.Parse(mj[j]);
        sb.Append(BinarySearch(arr, target) ? '1' : '0').AppendLine();
    }
}

Console.Write(sb.ToString()); 
