string[] d = Console.ReadLine().Split(" ");
double d1 = double.Parse(d[0]);
double d2 = double.Parse(d[1]);
double d3 = double.Parse(d[2]);

double a = (d1 + d2 + d3) / 2 - d3;
double b = (d1 + d2 + d3) / 2 - d2;
double c = (d1 + d2 + d3) / 2 - d1;
if (a <= 0 || b <= 0 || c <= 0)
{
    Console.WriteLine(-1);
    return;
}

else
{
    Console.WriteLine(1);
}

Console.WriteLine(a.ToString("F1") + " " + b.ToString("F1") + " " + c.ToString("F1"));
