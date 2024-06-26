string[] nx = Console.ReadLine().Split(" ");
int n =  int.Parse(nx[0]);
int x = int.Parse(nx[1]);

int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

long result = long.MaxValue;
for (int i = 0; i < n - 1; i++)
{
    result = Math.Min(result, (long)x * (a[i] + a[i + 1]));
}

Console.WriteLine(result);
