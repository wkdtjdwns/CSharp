int k = int.Parse(Console.ReadLine());

string[] d = Console.ReadLine().Split(" ");
int d1 = int.Parse(d[0]);
int d2 = int.Parse(d[1]);

double r1 = d1 / 2.0;
double r2 = d2 / 2.0;
double height = Math.Sqrt(k * k - (r1 - r2) * (r1 - r2)) * Math.Sqrt(k * k - (r1 - r2) * (r1 - r2)); ;

Console.WriteLine(height);
