string[] nmk = Console.ReadLine().Split(" ");
int m = int.Parse(nmk[1]);
int k = int.Parse(nmk[2]);

Console.WriteLine(k / m + " " + k % m);
