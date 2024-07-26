int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine("$" + (n * 0.8).ToString("F2"));
}
