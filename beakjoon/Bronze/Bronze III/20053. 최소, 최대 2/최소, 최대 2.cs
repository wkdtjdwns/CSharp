int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    string[] a = Console.ReadLine().Split(" ");
    int min = int.MaxValue;
    int max = int.MinValue;
    for (int j = 0; j < n; j++)
    {
        int num = int.Parse(a[j]);
        min = Math.Min(min, num);
        max = Math.Max(max, num);
    }

    Console.WriteLine(min + " " + max);
}
