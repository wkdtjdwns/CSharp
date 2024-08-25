string[] nmk = Console.ReadLine().Split(" ");
int n = int.Parse(nmk[0]);
int m = int.Parse(nmk[1]);
int k = int.Parse(nmk[2]);

Console.WriteLine(((m - 1) + (k - 3) % n + n) % n + 1);
