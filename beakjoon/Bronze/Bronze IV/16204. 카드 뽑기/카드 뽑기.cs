string[] nmk = Console.ReadLine().Split(" ");
int n = int.Parse(nmk[0]);
int k = int.Parse(nmk[1]);
int m = int.Parse(nmk[2]);

Console.WriteLine(Math.Min(m, k) + n - Math.Max(m, k));
