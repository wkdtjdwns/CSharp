int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

int x = a * p;
int y = 0;

if (c >= p) { y = b; }
else { y = b + ((p - c) * d); }

if (x < y) { Console.WriteLine(x); }
else { Console.WriteLine(y); }
