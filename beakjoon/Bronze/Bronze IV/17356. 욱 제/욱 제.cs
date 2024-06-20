string[] ab = Console.ReadLine().Split(" ");
double a = double.Parse(ab[0]);
double b = double.Parse(ab[1]);

double m = (b - a) / 400;
Console.WriteLine((1 / (1 + Math.Pow(10, m))).ToString("n20"));
