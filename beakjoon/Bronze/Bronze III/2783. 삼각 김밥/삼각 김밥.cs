string[] XY = Console.ReadLine().Split(" ");
double X = double.Parse(XY[0]);
double Y = double.Parse(XY[1]);
double R = (1000 / Y) * X;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] xy = Console.ReadLine().Split(" ");
    double x = double.Parse(xy[0]);
    double y = double.Parse(xy[1]);
    double r = (1000 / y) * x;

    R = Math.Min(R, r);
}

Console.WriteLine(R.ToString("F2"));
