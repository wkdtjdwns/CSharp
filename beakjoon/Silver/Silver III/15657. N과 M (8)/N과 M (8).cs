int n, m;
int[] arr, printArr;

void dfs(int start, int depth)
{
    if (depth == m)
    {
        for (int i = 0; i < m; i++)
        {
            Console.Write(printArr[i] + " ");
        }

        Console.WriteLine();
        return;
    }

    for (int i = start; i < n; i++)
    {
        printArr[depth] = arr[i];
        dfs(i, depth + 1);
    }
}

string[] nm = Console.ReadLine().Split(" ");
n = int.Parse(nm[0]);
m = int.Parse(nm[1]);

arr = new int[n];
printArr = new int[m];
string[] input = Console.ReadLine().Split(" ");

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(input[i]);
}


Array.Sort(arr);
dfs(0, 0);
