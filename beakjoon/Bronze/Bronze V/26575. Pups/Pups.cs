int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] abc = Console.ReadLine().Split(" ");
    double a = double.Parse(abc[0]);
    double b = double.Parse(abc[1]);
    double c = double.Parse(abc[2]);

    Console.WriteLine($"${(a * b * c).ToString("F2")}");
}
