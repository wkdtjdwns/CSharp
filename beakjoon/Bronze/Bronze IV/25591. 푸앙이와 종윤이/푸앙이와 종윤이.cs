string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);

int a = 100 - n;
int b = 100 - m;
int c = 100 - (a + b);
int d = a * b;
int q = d / 100;
int r = d % 100;

Console.WriteLine(a + " " + b + " " + c + " " + d + " " + q + " " + r);
Console.WriteLine(c + q + " " + r);
