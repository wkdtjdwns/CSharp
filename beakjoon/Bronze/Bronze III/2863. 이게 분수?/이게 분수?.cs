string[] ab = Console.ReadLine().Split(" ");
string[] cd = Console.ReadLine().Split(" ");
double a = double.Parse(ab[0]);
double b = double.Parse(ab[1]);
double c = double.Parse(cd[0]);
double d = double.Parse(cd[1]);

List<double> results = new List<double>
{
    ((a / c) + (b / d)),
    ((c / d) + (a / b)),
    ((d / b) + (c / a)),
    ((b / a) + (d / c))
};

double max = 0;
foreach (double result in results)
{
    max = Math.Max(max, result);
}

Console.WriteLine(results.IndexOf(max));
