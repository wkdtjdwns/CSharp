string[] apc = Console.ReadLine().Split(" ");
int a = int.Parse(apc[0]);
int p = int.Parse(apc[1]);
int c = int.Parse(apc[2]);

Console.WriteLine(Math.Max(a + c, p));
