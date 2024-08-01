int T = int.Parse(Console.ReadLine());
for (int i = 0; i < T; i++)
{
    string[] nm = Console.ReadLine().Split(" ");
    int n = int.Parse(nm[0]);
    int m = int.Parse(nm[1]);

    int u = m * 2 - n;
    int t = n - m;

    Console.WriteLine(u + " " + t);
}
