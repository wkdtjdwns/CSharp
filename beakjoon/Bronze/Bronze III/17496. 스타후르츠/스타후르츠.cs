string[] ntcp = Console.ReadLine().Split(" ");
int n = int.Parse(ntcp[0]);
int t = int.Parse(ntcp[1]);
int c = int.Parse(ntcp[2]);
int p = int.Parse(ntcp[3]);

Console.WriteLine((n - 1) / t * c * p);
