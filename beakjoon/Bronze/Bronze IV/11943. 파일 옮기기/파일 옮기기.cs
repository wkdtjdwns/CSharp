string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);

string[] cd = Console.ReadLine().Split(" ");
int c = int.Parse(cd[0]);
int d = int.Parse(cd[1]);

Console.WriteLine(Math.Min(a + d, b + c));
