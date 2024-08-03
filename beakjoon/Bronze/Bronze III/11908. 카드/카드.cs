int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
string[] c = Console.ReadLine().Split(" ");
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(c[i]);
}

Array.Sort(a);
int sum = 0;
for (int i = 0; i < n - 1; i++)
{
    sum += a[i];
}

Console.WriteLine(sum);
