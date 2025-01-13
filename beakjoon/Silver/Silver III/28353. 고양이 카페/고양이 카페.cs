string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);

int[] weights = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
Array.Sort(weights);

int i = 0;
int j = n - 1;
int cnt = 0;

while (i < j)
{
    if (weights[i] + weights[j] <= k)
    {
        cnt++;
        i++;
        j--;
    }

    else
    {
        j--;
    }
}

Console.WriteLine(cnt);
