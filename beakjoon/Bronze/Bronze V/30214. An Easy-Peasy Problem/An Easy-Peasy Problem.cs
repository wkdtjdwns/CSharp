string[] ab = Console.ReadLine().Split(" ");
double a = double.Parse(ab[0]);
double b = double.Parse(ab[1]);

Console.WriteLine((a >= b / 2) ? "E" : "H");
