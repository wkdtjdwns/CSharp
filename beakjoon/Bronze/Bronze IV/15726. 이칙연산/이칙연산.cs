string[] abc = Console.ReadLine().Split(" ");
double a = double.Parse(abc[0]);
double b = double.Parse(abc[1]);
double c = double.Parse(abc[2]);

int x = (int)((a * b) / c);
int y = (int)((a / b) * c);

Console.WriteLine((x > y) ? x : y);
