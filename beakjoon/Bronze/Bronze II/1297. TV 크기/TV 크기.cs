string[] dhw = Console.ReadLine().Split(" ");
double d = double.Parse(dhw[0]);
double h = double.Parse(dhw[1]);
double w = double.Parse(dhw[2]);

double pow = Math.Pow(d, 2) / (Math.Pow(h, 2) + Math.Pow(w, 2));
double sqrt = Math.Sqrt(pow);

Console.WriteLine((int)(sqrt * h) + " " + (int)(sqrt * w));
