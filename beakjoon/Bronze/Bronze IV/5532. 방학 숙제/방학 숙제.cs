int l = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

int k = (a % c == 0) ? (a / c) : (a / c) + 1;
int m = (b % d == 0) ? (b / d) : (b / d) + 1;

Console.Write(Math.Min(l - k, l - m));
