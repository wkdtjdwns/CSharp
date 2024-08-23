string[] nmk = Console.ReadLine().Split(" ");
int n = int.Parse(nmk[0]);
int m = int.Parse(nmk[1]);
int k = int.Parse(nmk[2]);

int min = Math.Max(0, n - m * k);
int max = Math.Max(0, n - m * (k - 1) - 1);
Console.WriteLine(min + " " + max);
