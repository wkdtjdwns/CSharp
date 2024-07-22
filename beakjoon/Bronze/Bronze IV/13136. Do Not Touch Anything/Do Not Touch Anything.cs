string[] rcn = Console.ReadLine().Split(" ");
double r = double.Parse(rcn[0]);
double c = double.Parse(rcn[1]);
double n = double.Parse(rcn[2]);

Console.WriteLine((long)Math.Ceiling(r / n) * (long)Math.Ceiling(c / n));
