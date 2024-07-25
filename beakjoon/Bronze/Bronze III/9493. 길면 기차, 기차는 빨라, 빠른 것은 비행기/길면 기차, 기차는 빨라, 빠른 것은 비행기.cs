while (true)
{
    string[] Mab = Console.ReadLine().Split(" ");
    double M = double.Parse(Mab[0]);
    double a = double.Parse(Mab[1]);
    double b = double.Parse(Mab[2]);

    if (M == 0 && a == 0 & b == 0) { break; }

    int result = (int)Math.Round(((M / a) - (M / b)) * 3600);

    int h = result / 3600;
    int m = (result / 60) % 60;
    int s = result % 60;

    Console.WriteLine($"{h}:{m:D2}:{s:D2}");
}
