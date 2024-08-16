string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);
int fk = k % 10;
int f2k = 2 * k % 10;
List<int> f = new List<int>();

for (int i = 1; i <= n; i++)
{
    int fx = i % 10;
    if (fx != fk && fx != f2k)
    {
        f.Add(i);
    }
}

Console.WriteLine(f.Count());
foreach (int i in f)
{
    Console.Write(i + " ");
}
