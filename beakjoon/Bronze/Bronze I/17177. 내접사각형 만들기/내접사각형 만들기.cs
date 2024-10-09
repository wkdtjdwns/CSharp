string[] abc = Console.ReadLine().Split(" ");
int a = int.Parse(abc[0]);
int b = int.Parse(abc[1]);
int c = int.Parse(abc[2]);

int p = a;
int q = 2 * b * c;
int r = a * (c * c - a * a + b * b);

int d = q * q - 4 * p * r;
if (d < 0)
{
    Console.WriteLine(-1);
    return;
}

double x = (-q + Math.Sqrt(d)) / (2 * p);
if (x < 0)
{
    Console.WriteLine(-1);
    return;
}

Console.WriteLine((int)(x + 1e-5));
