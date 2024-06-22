string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

Console.WriteLine(Math.Min(n / 2, m / 2));
