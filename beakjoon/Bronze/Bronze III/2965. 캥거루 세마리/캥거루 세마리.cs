string[] abc = Console.ReadLine().Split(" ");
Array.Sort(abc);

int a = int.Parse(abc[0]);
int b = int.Parse(abc[1]);
int c = int.Parse(abc[2]);
Console.WriteLine(Math.Max(c - b, b - a) - 1);
