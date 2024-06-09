string[] input = Console.ReadLine().Split(" ");
double w = double.Parse(input[0]);
double h = double.Parse(input[1]);

Console.WriteLine((w * h / 2).ToString("0.0"));
