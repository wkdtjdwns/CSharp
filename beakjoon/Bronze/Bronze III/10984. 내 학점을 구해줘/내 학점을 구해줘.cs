int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    double C = 0;
    double G = 0;

    int n = int.Parse(Console.ReadLine());
    for (int j = 0; j < n; j++)
    {
        string[] cg = Console.ReadLine().Split(" ");
        double c = double.Parse(cg[0]);
        double g = double.Parse(cg[1]);

        C += c;
        G += c * g;
    }

    Console.WriteLine((int)C + " " + (G / C).ToString("F1"));
}
