int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] abcde = Console.ReadLine().Split(" ");
    int a = int.Parse(abcde[0]);
    int b = int.Parse(abcde[1]);
    int c = int.Parse(abcde[2]);
    int d = int.Parse(abcde[3]);
    int e = int.Parse(abcde[4]);

    double total = a * 350.34 + b * 230.90 + c * 190.55 + d * 125.30 + e * 180.90;
    Console.WriteLine("$" + total.ToString("F2"));
}
