string[] ab = Console.ReadLine().Split(" ");
double a = double.Parse(ab[0]);
double b = double.Parse(ab[1]);

double d = a - (a * (b / 100));
if (d >= 100)
{
    Console.WriteLine(0);
}

else
{
    Console.WriteLine(1);
}
