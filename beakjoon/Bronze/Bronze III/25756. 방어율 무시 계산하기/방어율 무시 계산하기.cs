int n = int.Parse(Console.ReadLine());
string[] a = Console.ReadLine().Split(" ");
double v = 0;
for (int i = 0; i < n; i++)
{
    int cur = int.Parse(a[i]);
    v = cur + v - v * cur / 100;

    Console.WriteLine(v);
}
