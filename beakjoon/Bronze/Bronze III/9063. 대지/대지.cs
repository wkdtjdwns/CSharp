int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
int[] b = new int[n];

for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    a[i] = int.Parse(ab[0]);
    b[i] = int.Parse(ab[1]);
}

Array.Sort(a);
Array.Sort(b);

Console.WriteLine((a[n - 1] - a[0]) * (b[n - 1] - b[0]));
