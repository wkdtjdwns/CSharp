int p = int.Parse(Console.ReadLine());
for (int i = 0; i < p; i++)
{
    string[] ndabf = Console.ReadLine().Split(" ");
    int n = int.Parse(ndabf[0]);
    double d = double.Parse(ndabf[1]);
    double a = double.Parse(ndabf[2]);
    double b = double.Parse(ndabf[3]);
    double f = double.Parse(ndabf[4]);

    Console.WriteLine(n + " " + ((d / (a + b)) * f).ToString("F6"));
}
