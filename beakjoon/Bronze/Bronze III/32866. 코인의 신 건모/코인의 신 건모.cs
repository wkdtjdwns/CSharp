int n = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
double result = (1 / (1 - x / 100.0) - 1) * 100;

Console.WriteLine($"{result:F6}");
